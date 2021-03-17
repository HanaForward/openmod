# OpenMod [![Discord](https://img.shields.io/discord/666327627124047872?label=Discord&style=for-the-badge)](https://discord.com/invite/jRrCJVm)

OpenMod 是一个 .Net 插件框架

它支持权限配置,插件配置,容器化,命令监听等等. OpenMod可以用于游戏，机器人框架，Web服务器或其他,并具有Unturned和Rust (WIP) 和 独立的控制台.

可用的插件列表 [openmod-plugins] (https://github.com/openmod/openmod-plugins). 

## 功能
基于现代化开发流程的最佳方案.
- 使用C#和Unity最优秀的先进API进行插件开发
- 使用NuGet进行插件安装与管理 [NuGet](https://nuget.org)
- 能够使用NuGet进行自更新
- 基于.Net 通用主机 [.NET Generic Host](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/host/generic-host)
- 使用Autofac 接管容器并进行依赖注入
- 采取Yaml配置框架、插件、环境变量、命令行参数等等.
- 使用Serilog丰富日志, 包括 logging.yml 日志的配置等

## 开始
要开始使用，请访问 [OpenMod Documentation](https://openmod.github.io/openmod-docs/).

如果要安装OpenMod，则可以使用以下指南：
- [Unturned](https://openmod.github.io/openmod-docs/userdoc/installation/unturned.html)

如果您想为OpenMod制作插件，则可以通过阅读 [制作第一个插件](https://openmod.github.io/openmod-docs/devdoc/guides/getting-started.html)

## 支持的游戏
现在Unturned是唯一受支持的游戏,将来可能还会有更多游戏。

A RocketMod 4 bridge has been made, which allows to run legacy RM4 plugins.
The configs for RM4 are yet to be decided to be separate, or to be proxied.

## 许可
更多信息请参加 [LICENSE](LICENSE) 文件

## Build Status [![LGTM alerts](https://img.shields.io/lgtm/alerts/github/openmod/openmod?style=for-the-badge)](https://lgtm.com/projects/g/openmod/openmod/)
### Framework
[![OpenMod.API](https://github.com/openmod/OpenMod/workflows/OpenMod.API/badge.svg)](https://github.com/openmod/OpenMod/actions?query=workflow%3AOpenMod.API) [![OpenMod.Bootstrapper](https://github.com/openmod/OpenMod/workflows/OpenMod.Bootstrapper/badge.svg)](https://github.com/openmod/OpenMod/actions?query=workflow%3AOpenMod.Bootstrapper) [![OpenMod.NuGet](https://github.com/openmod/OpenMod/workflows/OpenMod.NuGet/badge.svg)](https://github.com/openmod/OpenMod/actions?query=workflow%3AOpenMod.NuGet) [![OpenMod.Core](https://github.com/openmod/OpenMod/workflows/OpenMod.Core/badge.svg)](https://github.com/openmod/OpenMod/actions?query=workflow%3AOpenMod.Core) [![OpenMod.Runtime](https://github.com/openmod/OpenMod/workflows/OpenMod.Runtime/badge.svg)](https://github.com/openmod/OpenMod/actions?query=workflow%3AOpenMod.Runtime) [![OpenMod.Analyzers](https://github.com/openmod/OpenMod/workflows/OpenMod.Analyzers/badge.svg)](https://github.com/openmod/OpenMod/actions?query=workflow%3AOpenMod.Analyzers) [![OpenMod.Templates](https://github.com/openmod/OpenMod/workflows/OpenMod.Templates/badge.svg)](https://github.com/openmod/OpenMod/actions?query=workflow%3AOpenMod.Templates) [![OpenMod.EntityFrameworkCore](https://github.com/openmod/OpenMod/workflows/OpenMod.EntityFrameworkCore/badge.svg)](https://github.com/openmod/OpenMod/actions?query=workflow%3AOpenMod.EntityFrameworkCore)

### Extensions
[![OpenMod.Extensions.Games.Abstractions](https://github.com/openmod/OpenMod/workflows/OpenMod.Extensions.Games.Abstractions/badge.svg)](https://github.com/openmod/OpenMod/actions?query=workflow%3AOpenMod.Extensions.Games.Abstractions) [![OpenMod.Extensions.Economy.Abstractions](https://github.com/openmod/OpenMod/workflows/OpenMod.Extensions.Economy.Abstractions/badge.svg)](https://github.com/openmod/OpenMod/actions?query=workflow%3AOpenMod.Extensions.Economy.Abstractions)

### Standalone
[![OpenMod.Standalone](https://github.com/openmod/OpenMod/workflows/OpenMod.Standalone/badge.svg)](https://github.com/openmod/OpenMod/actions?query=workflow%3AOpenMod.Standalone)

### UnityEngine
[![OpenMod.UnityEngine.Redist](https://github.com/openmod/OpenMod/workflows/OpenMod.UnityEngine.Redist/badge.svg)](https://github.com/openmod/OpenMod/actions?query=workflow%3AOpenMod.UnityEngine.Redist) [![OpenMod.UniTask](https://github.com/openmod/OpenMod/workflows/OpenMod.UniTask/badge.svg)](https://github.com/openmod/OpenMod/actions?query=workflow%3AOpenMod.UniTask) [![OpenMod.UnityEngine](https://github.com/openmod/OpenMod/workflows/OpenMod.UnityEngine/badge.svg)](https://github.com/openmod/OpenMod/actions?query=workflow%3AOpenMod.UnityEngine)

### Unturned
[![OpenMod.Unturned.Redist](https://github.com/openmod/OpenMod/workflows/OpenMod.Unturned.Redist/badge.svg)](https://github.com/openmod/OpenMod/actions?query=workflow%3AOpenMod.Unturned.Redist) [![OpenMod.Unturned](https://github.com/openmod/OpenMod/workflows/OpenMod.Unturned/badge.svg)](https://github.com/openmod/OpenMod/actions?query=workflow%3AOpenMod.Unturned) [![OpenMod.Unturned.Module](https://github.com/openmod/OpenMod/workflows/OpenMod.Unturned.Module/badge.svg)](https://github.com/openmod/OpenMod/actions?query=workflow%3AOpenMod.Unturned.Module)

### Rust
[![OpenMod.Rust.Redist](https://github.com/openmod/OpenMod/workflows/OpenMod.Rust.Redist/badge.svg)](https://github.com/openmod/OpenMod/actions?query=workflow%3AOpenMod.Rust.Redist) [![OpenMod.Rust](https://github.com/openmod/OpenMod/workflows/OpenMod.Rust/badge.svg)](https://github.com/openmod/OpenMod/actions?query=workflow%3AOpenMod.Rust) [![OpenMod.Rust.Oxide.Redist](https://github.com/openmod/OpenMod/workflows/OpenMod.Rust.Oxide.Redist/badge.svg)](https://github.com/openmod/OpenMod/actions?query=workflow%3AOpenMod.Rust.Oxide.Redist) [![OpenMod.Rust.Oxide](https://github.com/openmod/OpenMod/workflows/OpenMod.Rust.Oxide/badge.svg)](https://github.com/openmod/OpenMod/actions?query=workflow%3AOpenMod.Rust.Oxide) [![OpenMod.Rust.Oxide.Extension](https://github.com/openmod/OpenMod/workflows/OpenMod.Rust.Oxide.Extension/badge.svg)](https://github.com/openmod/OpenMod/actions?query=workflow%3AOpenMod.Rust.Oxide.Extension) [![OpenMod.Rust.Oxide.PermissionLink](https://github.com/openmod/OpenMod/workflows/OpenMod.Rust.Oxide.PermissionLink/badge.svg)](https://github.com/openmod/OpenMod/actions?query=workflow%3AOpenMod.Rust.Oxide.PermissionLink)
