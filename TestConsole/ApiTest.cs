﻿using EleCho.GoCqHttpSdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AssemblyCheck
{
    internal static class ApiTest
    {
        const long TestGroupId = 609116135;
        const long TestUserId = 3257726229;

        public static async Task RunAsync(ICqActionSession session)
        {
            var url = "https://bing.com";

            var safety = await session.CheckUrlSafety(url);
            await session.SendGroupMessageAsync(TestGroupId, $"连接安全性: {url} {safety.Level}");

            var versionInfo = await session.GetVersionInformation();
            await session.SendGroupMessageAsync(TestGroupId, JsonSerializer.Serialize(versionInfo));
        }
    }
}
