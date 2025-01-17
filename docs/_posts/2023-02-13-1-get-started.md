---
layout: post
title:  "1. 快速开始"
date:   2023-02-13 17:18:00 +0800
categories: tutorial
---



简单来讲, Go-CqHttp 是一个 QQ 机器人框架, 如果我们要编写一个 QQ 机器人, 那么借助 Go-CqHttp 就可以非常简单的实现.



## 概述

Go-CqHttp 会负责 QQ 的通信, 作为一个 "QQ 客户端" 进行消息的接收与发送. 而我们要执行我们想要的逻辑, 只需要跟 Go-CqHttp 进行通信, 调用我们想要的功能, 接收我们想要的数据, 而不需要关心 QQ 具体的背后实现.

一般的, 你需要运行一个 Go-CqHttp 程序, 然后运行你自己的程序. 你自己的程序会与 Go-CqHttp 使用 HTTP 或 WebSocket 进行通信, 以实现 QQ 机器人.

```
自己的程序 <---> Go-CqHttp <---> 腾讯 QQ 服务器
```



## 操作

配置 Go-CqHttp 并运行它, 它会登陆你设定的 QQ 号, 然后现在, 它已经开始消息的接收了

要使 Go-CqHttp 发送一条消息, 你需要让机器人程序, 对 Go-CqHttp 所监听的端口发送一个 HTTP 请求, 在请求的参数中包含我们要进行的操作, 操作具体的参数, 这样, 就能实现最简单的动作执行.

```http
GET /api/send_private_msg?user_id=114514&message=hello_world HTTP/1.1
```

```
机器人程序 --> Go-CqHttp -> 腾讯 QQ 服务器
```



## 上报

为了接收消息, Go-CqHttp 需要主动向我们的程序汇报数据, 有两种方案:

1. 机器人程序监听一个端口, Go-CqHttp 向这个端口发送 HTTP 请求
2. 机器人程序与 Go-CqHttp 建立一个 WebSocket 连接, 这样 Go-CqHttp 就可以通过 WebSocket 主动向我们发送数据

这两种方案, 就叫做 Go-CqHttp 的 `反向 HTTP` 和 `WebSocket` 通信方式. 其中, `WebSocket` 可以是机器人程序连接到 Go-CqHttp, 也可以是 Go-CqHttp 连接到机器人程序.



## 对比

事实上, Go-CqHttp 是 OneBot 标准的一个实现, 上述的操作与上报, 都是 OneBot 中规范好的. 除了 Go-CqHttp, 还有着许多的 QQ 机器人框架, 例如已经死去的酷 Q, 或者如今大火的 Mirai. 但笔者认为, 最便捷稳定的, 还是这里介绍的 Go-CqHttp

Mirai 的使用, 需要进行复杂的配置, 安装插件, 有时你还会因网络问题而导致无法安装依赖包, 或者有时候你也会遇到包版本不同所导致的兼容性问题. 而这些, 在 Go-CqHttp 中统统不存在. 下载, 解压, 编辑配置文件, 运行. 开箱即用, 这是 Go-CqHttp 的优点.