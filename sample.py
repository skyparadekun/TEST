# -*- coding: utf-8 -*-

# 插件加载方法： 
# 先运行 qqbot ，启动成功后，在另一个命令行窗口输入： qq plug qqbot.plugins.sample

def onQQMessage(bot, contact, member, content):
    if member!=None:
        if contact.ctype=="group" and contact.mark=="W3部长群":
            if "大家好，我是" in content:
                bot.SendTo(contact,"欢迎"+content[6:]+"同学")
            elif content=="request-bot: STOP":
                bot.SendTo(contact, 'QQ机器人已关闭')
                bot.Stop()
