﻿namespace Meowv.Blog.Domain.Shared
{
    /// <summary>
    /// 全局常量
    /// </summary>
    public class MeowvBlogGlobalConsts
    {
        /// <summary>
        /// 分组
        /// </summary>
        public static class Grouping
        {
            /// <summary>
            /// 博客前台接口组
            /// </summary>
            public const string GroupName_v1 = "v1";

            /// <summary>
            /// 博客后台接口组
            /// </summary>
            public const string GroupName_v2 = "v2";

            /// <summary>
            /// 其他通用接口组
            /// </summary>
            public const string GroupName_v3 = "v3";
        }

        /// <summary>
        /// 语音合成欢迎词
        /// </summary>
        public const string GreetWord = "欢迎来到我的个人博客，我是阿星Plus。今日语录：{0}，{1}";
    }
}