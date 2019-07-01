using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Solution.API.Code;
using Solution.Entity.Enums;
using Solution.Entity.UserModule;
using Solution.Service;
using Solution.Service.LogsModule;
using Solution.Service.UserModule;
using WeiFos.Core.Extensions;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using WeiFos.Core.NetCoreConfig;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System.Security.Principal;

namespace Solution.API.Controllers
{
    public class PassportController : BaseController
    {

        /// <summary>
        /// 用户接口入口
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> Index(int id)
        {
            switch (id)
            {
                //登录
                case 100: return await Func100();
                //默认返回失败
                default: return Ok(APIResponse.GetResult(StateCode.State_6));
            }
        }


        /// <summary>
        /// 登录
        /// </summary>
        /// <returns></returns>
        private async Task<IActionResult> Func100()
        {
            return await Task.Run(() =>
            {
                try
                { 
                    //用户
                    string login_name = Dynamic.Data.LoginName.ToString();

                    //密码
                    string pass_word = Dynamic.Data.Password.ToString();

                    //是否登录
                    User user = ServiceIoc.Get<UserService>().Login(login_name, pass_word, HttpContext.GetClientIp(), Sign);
                    if (user.login_code == StateCode.State_200)
                    {
                        var claims = new[] {
                            new Claim(JwtRegisteredClaimNames.Sub,user.login_name), 
                            new Claim("UserId", user.id.ToString()),
                            new Claim("HeadImg", user.head_img ?? "")
                        };

                        ClaimsIdentity identity = new ClaimsIdentity(new GenericIdentity(user.login_name, "TokenAuth"), claims);

                        var now = DateTime.UtcNow;
                        var ex = now + TimeSpan.FromMinutes(60);
                        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(ConfigManage.AppSettings<string>("Jwt:Key")));
                        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);//加密方式
                        var token = new SecurityTokenDescriptor
                        {
                            //Jwt token 的签发者
                            Issuer = ConfigManage.AppSettings<string>("AppSettings:DomainApi"),
                            //Jwt token 的接收者
                            Audience = ConfigManage.AppSettings<string>("AppSettings:DomainApi"),
                            IssuedAt = now,
                            Expires = ex,
                            SigningCredentials = creds,
                            Subject = identity
                        };

                        //基于Jwt身份认证
                        //var userPrincipal = new ClaimsPrincipal(new ClaimsIdentity(claims, JwtBearerDefaults.AuthenticationScheme));

                        //签发一个加密后的用户信息凭证，用来标识用户的身份
                        HttpContext.SignInAsync(JwtBearerDefaults.AuthenticationScheme, new ClaimsPrincipal(identity));

                        var tokenHandler = new JwtSecurityTokenHandler();

                        return APIResponse.GetResult(user.login_code, new
                        {
                            token = tokenHandler.CreateEncodedJwt(token), 
                            sid = user.id,
                            name = user.login_name,
                            auth_time = new DateTimeOffset(now).ToUnixTimeSeconds(),
                            expires_at = new DateTimeOffset(ex).ToUnixTimeSeconds()
                        });
                    } 

                    return APIResponse.GetResult(user.login_code);
                }
                catch (Exception ex)
                {
                    ServiceIoc.Get<APILogsService>().Save("登录接口==>" + ex.ToString());
                    return APIResponse.GetResult(StateCode.State_500);
                }
            });
        }




    }
}