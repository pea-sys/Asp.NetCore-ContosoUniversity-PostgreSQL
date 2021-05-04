# Asp.NetCore-ContosoUniversity
[MicroSoft公式のASP.Net Coreのデータアクセスチュートリアル](https://docs.microsoft.com/ja-jp/aspnet/core/data/ef-rp/intro?view=aspnetcore-5.0&tabs=visual-studio)

チュートリアルではSQL Serverを使用しているがPostgreSQLを使用  


PostgreSQLを使用する場合、appsettings.jsonにコネクション情報を記載する必要がある。  
https://faun.pub/asp-net-core-entity-framework-core-with-postgresql-code-first-d99b909796d7


コネクション情報にはパスワード等含まれており、サーバで公開したくない場合が多いので、以下を参考にsecret.jsonで管理  
https://docs.microsoft.com/ja-jp/aspnet/core/security/app-secrets?view=aspnetcore-5.0&tabs=linux

以下コマンドでWindowsだとC:\Users\user\AppData\Roaming\Microsoft\UserSecretsにsecret.jsonが格納されたフォルダが作成される
```
dotnet user-secrets init
```
あとは、以下のCLIで編集するなり直接編集するなりすれば、appsettings.jsonのsecret化が出来る
```
dotnet user-secrets set "Movies:ServiceApiKey" "12345"
```



