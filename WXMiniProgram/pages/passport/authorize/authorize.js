//应用实列
const app = getApp()
var passport = require("../../.././modules/passport.js")
var WXBizDataCrypt = require('../../../utils/WXBizDataCrypt.js')

Page({

  /**
   * 页面的初始数据
   */
  data: {

  },

  /**
   * 生命周期函数--监听页面加载
   */
  onLoad: function (options) {

  },

  /**
   * 生命周期函数--监听页面初次渲染完成
   */
  onReady: function () {

  },

  /**
   * 生命周期函数--监听页面显示
   */
  onShow: function () {

  },

  /**
   * 生命周期函数--监听页面隐藏
   */
  onHide: function () {

  },

  /**
   * 生命周期函数--监听页面卸载
   */
  onUnload: function () {

  },

  /**
   * 页面相关事件处理函数--监听用户下拉动作
   */
  onPullDownRefresh: function () {

  },

  /**
   * 页面上拉触底事件的处理函数
   */
  onReachBottom: function () {

  },

  /**
   * 用户点击右上角分享
   */
  onShareAppMessage: function () {

  },

  /**
   * 获取用户授权信息
   */
  GetUserInfo: function (e) {
    if (e.detail.errMsg == 'getUserInfo:ok') {
      console.log(e.detail.errMsg)
      console.log(e.detail.userInfo)
      console.log(e.detail.rawData)
      debugger
      //允许授权后获取用户信息进行保存，并上传服务器
      passport.getUserInfo()
      wx.redirectTo({
        url: '../../user/index/index'
      })
    } else {
      wx.redirectTo({
        url: '../../user/index/index'
      })
    }
  }

})