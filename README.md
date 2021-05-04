[MicroSoft公式のASP.Net Coreのデータアクセスチュートリアル](https://docs.microsoft.com/ja-jp/aspnet/core/data/ef-rp/intro?view=aspnetcore-5.0&tabs=visual-studio)

チュートリアルではSQL Serverを使用しているがPostgreSQLを使用  
以下PostgreSQLに変更した際の作業メモ

### ■コネクション情報の隠蔽
PostgreSQLを使用する場合、appsettings.jsonにコネクション情報を記載する必要がある。  
https://faun.pub/asp-net-core-entity-framework-core-with-postgresql-code-first-d99b909796d7


コネクション情報にはパスワード等含まれている。  
公開したくない場合が多いので、以下を参考にsecret.jsonで管理  
https://docs.microsoft.com/ja-jp/aspnet/core/security/app-secrets?view=aspnetcore-5.0&tabs=linux

以下コマンドでWindowsだとC:\Users\user\AppData\Roaming\Microsoft\UserSecretsにsecret.jsonが格納されたフォルダが作成される
```
dotnet user-secrets init
```
あとは、以下のCLIで編集するなり直接編集するなりすれば、appsettings.jsonのsecret化が出来る
```
dotnet user-secrets set "Movies:ServiceApiKey" "12345"
```
### ■同時実行制御
SQLSeverだとConcurrency Tokenが既定で存在するようだが、PostgreSQLにはないのでシステム列のxmin(トランザクションid)で代用する  
余談だが、１つのトランザクションでxminが採番されるので、複数行が同じxminを持つ場合も多い(特に問題はない)


[備考]  
SQLServerからPostgreSQLに移行する際に、EFがPostgreSQLに対してSQLServer向けのテーブル定義構文を投げていたため、移行失敗
正しい解決方法は不明だがMigrationフォルダを全削除したら、正しい構文で動作するようになった



