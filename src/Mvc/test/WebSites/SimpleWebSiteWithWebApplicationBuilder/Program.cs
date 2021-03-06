// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.AspNetCore.Builder;

var app = WebApplication.Create(args);

app.MapGet("/", (Func<string>)(() => "Hello World"));

app.Run();
