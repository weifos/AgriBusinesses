export default {
    data: {
        user: { token: cookie.get("token") == undefined ? '' : cookie.get("token") },
        confirmOrder: {},
        historyKeyWord: [],
        hisCourseKeyWord: [],
        historyProduct: []
    },
    methods: {
        //登录设置本地数据
        login(result) {
            this.user = result
            cookie.set('token', result.token, { path: '/', expires: 30 })
            try {
                //解决用app内嵌的webview打开网站时，localStorage就失效了
                //如果在app里面嵌入 ws.setDomStorageEnabled(true) 设置该属性
                window.localStorage.setItem("user_info", JSON.stringify(result))
            }
            catch (err) {
                alert(err) // 可执行 
            }
        },
        //登录设置本地数据
        loginOut() {
            this.user = { token: '' }
            cookie.remove('token', { path: '/' })
            window.localStorage.removeItem("user_info")
        },//刷新登录
        refreshLogin(cb) {
            let $this = this
            this.post(app_g.api.api_300, this.GetSign(),
                function (vue, res) {
                    if (res.data.Basis.State == app_g.state.state_200) {
                        $this.login(res.data.Result)
                        cb(res.data.Result)
                    } else {
                        vue.$vux.toast.text(res.data.Basis.Msg, 'default')
                    }
                }
            )
        },//提交购物
        sumitSCart(result) {
            this.sCartOrder = result
            window.localStorage.removeItem('sCartOrder')
            window.localStorage.setItem("sCartOrder", JSON.stringify(result))
        },//提交立即购买
        buyNow(result) {
            this.buyNowOrder = result
            window.localStorage.removeItem('buyNowOrder')
            window.localStorage.setItem("buyNowOrder", JSON.stringify(result))
        },//设置历史查看商品
        setHistoryProduct(result) {
            if (result == undefined || result == '') return
            let products = window.localStorage.getItem("historyProduct")
            if (products == null) {
                products = []
                products.push(result)
            } else {
                products = JSON.parse(products)
                if (!products.some((ele) => { return ele.id == result.id })) {
                    products.splice(0, 0, result)
                    if (products.length > 10) {
                        products.splice(products.length - 1, 1)
                    }
                }
            }

            window.localStorage.setItem("historyProduct", JSON.stringify(products))
            this.historyProduct = products
        },//设置历史查询关键词
        setHistoryKeyWord(result) {
            if (result == undefined || result == '') return
            let keyWords = window.localStorage.getItem("historyKeyWord")
            if (keyWords == null) {
                keyWords = []
                keyWords.push(result)
            } else {
                keyWords = JSON.parse(keyWords)
                if (!keyWords.some((ele) => { return ele == result })) {
                    keyWords.splice(0, 0, result)
                    if (keyWords.length > 10) {
                        keyWords.splice(keyWords.length - 1, 1)
                    }
                }
            }

            window.localStorage.setItem("historyKeyWord", JSON.stringify(keyWords))
            this.historyKeyWord = keyWords
        },//设置课程查询历史关键词
        setHisCourseKeyWord(result) {
            if (result == undefined || result == '') return
            let keyWords = window.localStorage.getItem("hisCourseKeyWord")
            if (keyWords == null) {
                keyWords = []
                keyWords.push(result)
            } else {
                keyWords = JSON.parse(keyWords)
                if (!keyWords.some((ele) => { return ele == result })) {
                    keyWords.splice(0, 0, result)
                    if (keyWords.length > 10) {
                        keyWords.splice(keyWords.length - 1, 1)
                    }
                }
            }

            window.localStorage.setItem("hisCourseKeyWord", JSON.stringify(keyWords))
            this.hisCourseKeyWord = keyWords
        },//删除单个历史查询关键词
        delHistoryKeyWord(keyword) {
            if (this.historyKeyWord.length == 0) return
            this.historyKeyWord.forEach((ele, index) => {
                if (ele == keyword) {
                    this.historyKeyWord.splice(index, 1)
                }
            })
            window.localStorage.setItem("historyKeyWord", JSON.stringify(this.historyKeyWord))
            this.historyKeyWord = this.historyKeyWord
        },//删除课程单个历史查询关键词
        delHisCourseKeyWord(keyword) {
            if (this.hisCourseKeyWord.length == 0) return
            this.hisCourseKeyWord.forEach((ele, index) => {
                if (ele == keyword) {
                    this.hisCourseKeyWord.splice(index, 1)
                }
            })
            window.localStorage.setItem("hisCourseKeyWord", JSON.stringify(this.hisCourseKeyWord))
            this.hisCourseKeyWord = this.hisCourseKeyWord
        },//清空历史查询关键词
        clearHistoryKeyWord() {
            if (this.historyKeyWord.length == 0) return
            this.$vux.confirm.show({
                title: '确认清空吗',
                onCancel() { },
                onConfirm() {
                    window.localStorage.setItem("historyKeyWord", JSON.stringify([]))
                    this.historyKeyWord = []
                }
            })

        },//清空历史查询关键词
        clearHisCourseKeyWord() {
            if (this.hisCourseKeyWord.length == 0) return
            this.$vux.confirm.show({
                title: '确认清空吗',
                onCancel() { },
                onConfirm() {
                    window.localStorage.setItem("hisCourseKeyWord", JSON.stringify([]))
                    this.hisCourseKeyWord = []
                }
            })

        },//是否登录
        islogin() {
            if (cookie.get("token") == undefined) {
                this.$vux.toast.text("当前页面需要登录", "default")
                router.push({ path: "/passport/login?backUrl=" + router.history.current.path })
                //this.$router.push({ path: '/passport/login' })
                return false
            } else {
                return true
            }
        },
        openid() {
            return cookie.get("openid")
        }
    },
    created() {
        let userInfoData = window.localStorage.getItem("user_info")
        if (userInfoData) {
            this.user = JSON.parse(userInfoData)
        }

        //提交购物车
        let sCOrder = window.localStorage.getItem("sCartOrder")
        if (sCOrder) {
            this.sCartOrder = JSON.parse(sCOrder)
        }

        //立即购买
        let buyNow = window.localStorage.getItem("buyNowOrder")
        if (buyNow) {
            this.buyNowOrder = JSON.parse(buyNow)
        }

        let keyWords = window.localStorage.getItem("historyKeyWord")
        if (keyWords) {
            this.historyKeyWord = JSON.parse(keyWords)
        }

        let products = window.localStorage.getItem("historyProduct")
        if (products) {
            this.historyProduct = JSON.parse(products)
        }
    }
}

