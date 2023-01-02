﻿#region Copyright 2021-2023 C. Augusto Proiete & Contributors
//
// Licensed under the MIT (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://opensource.org/licenses/MIT
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#endregion

using Cake.Jekyll.Commands.Clean;
using Cake.Jekyll.Tests.Support;

namespace Cake.Jekyll.Tests.Commands.Clean;

internal sealed class JekyllCleanCommandFixture : JekyllFixture<JekyllCleanSettings>
{
    protected override void RunTool()
    {
        var tool = new JekyllCleanCommand(FileSystem, Environment, ProcessRunner, Tools, Log);
        tool.Clean(Settings);
    }
}
