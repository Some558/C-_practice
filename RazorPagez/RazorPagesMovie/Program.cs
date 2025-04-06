// アプリをビルドするコード
var builder = WebApplication.CreateBuilder(args);
// アプリでRazorPagesが使えるようになる
builder.Services.AddRazorPages();
// 依存性注入
var app = builder.Build();

// 開発環境ではない場合の処理
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}
// https化
app.UseHttpsRedirection();
// ルーティングミドルウェア追加
app.UseRouting();
// 認証機能の追加
app.UseAuthorization();
// 静的ファイルをブラウザに提供するための設定
app.MapStaticAssets();
// Razor Pagesのルーティング化
app.MapRazorPages()
   .WithStaticAssets();
// アプリケーションの起動
app.Run();
