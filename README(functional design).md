# ChatApps

## ペルソナ

プロフィール  
性別：男性  
年齢：28歳、独身  
A社社員であり、入社6年目、チーム運営の経験も積みつつ自信はテックリードとしてチームを引っ張る。  
社内チャットツールの使い辛さに以前より不満を感じており、今回の新ツール導入を心待ちにしている。

ライフスタイル  
趣味はパズドラ。  
友人に誘われ始めたが、周りの友人たちが辞めていくなか惰性で続けている。  
プライベートでは自分から主導して何かを始めたり決めたりするのが苦手で、他人の意見に左右されやすいなと感じている。  
他にやりたいこともないので貯金だけは順調に増え続けている。  
それなりの額になってきたので投資に回す予定。  

価値観
性格：事なかれ主義  
主な情報収集の手段・ツール：ニュースサイト  
悩み：実年齢より年上に見られる  
解決方法：とにかく調べる  
商品認知：サービス自体は知らない  
商品検討のプロセス：迷ったら1日置いて、それでも欲しければ  
選定ポイント：  
優先事項：  

その他  
「資本主義は終わりを迎え、次は"希望"の時代が来る」と最近は思っている。

## ユーザーストーリー

依頼主であるA社では社内ツールとしてZ社のチャットツールを使用している。
しかし、一度ユーザー登録をするとユーザー情報の編集・削除ができない、
やり取りが文字のみで画像のやり取りができないなど、
使いづらさを感じている。
そこでA社は上記要件を満たしたチャットツールの作成をO社に依頼した。

以下はA社からの要望をまとめたものである。

- 現状100名規模だが、今後社員数の増加を見込んで最大500名が使用しても耐えうるものにしたい。

- ユーザーの登録、編集、削除を行える
- 管理者ユーザーと一般ユーザー、で権限を分け、一般ユーザーはユーザー登録・情報更新を行える
- 管理者ユーザーはユーザー登録・情報更新・削除操作を行える
- パスワードはパスワードハッシングにより暗号化し、セキュリティ性を高める
 今回C#.NET COREでの開発を想定しているため、PasswordHashクラスを使うことで実現する
 <https://learn.microsoft.com/ja-jp/dotnet/api/microsoft.aspnetcore.identity.passwordhasher-1?view=aspnetcore-8.0>

ユーザー情報は以下を登録できる。

- 苗字名前
- メールアドレス
- パスワード
- プロフィール画像

## アーキテクト

.NET SDK 8.0
.NET Runtime 8.0
ASP.NET Core Runtime 8.0

バックエンド  
C#  
ASP.net Core MVC  

フロントエンド  
TypeScript  
Node.js  
HTML  
CSS  

## 概要

A社様ご依頼  
ユーザー同士が交流できる掲示板アプリケーションです。  
ユーザーは会員登録することで好きなテーマでチャットルームを作成できます。  
また、現行で使用しているチャットツールには画像投稿機能がなく円滑な情報共有ができていない問題を抱えているため、
画像投稿機能を実装します。  

## 機能一覧

一般ユーザー

- サインイン
- サインアップ
- チャットルーム（作成・削除）
- コメント投稿
- 画像投稿

管理者ユーザー

- サインイン
- サインアップ
- チャットルーム（作成・削除）
- ユーザー管理(登録・情報更新・削除)
- コメント投稿
- コメント管理(削除)
- 画像投稿
- 画像管理(削除)


## 画面遷移図・画面モック

STUDIOにて管理
<https://app.studio.design/projects/nBW2pyjeqv/dashboard/home>

## API一覧

ApiDogにて管理
<https://app.apidog.com/invite/project?token=ck5Xbll0E8ReIYY4OjAhM>

## (工数メモ、気にしないで)

池谷さん
基本設計
レビュー前チェック1.5h
レビュー1.5h
レビュー前チェック2回目：1.0h
レビュー2回目1.5h

川嶋
基本設計 8h
レビュー受 1.5h
レビュー受2回目：1.5h

基本設計レビュー後対応 5h + 1h + 2.5h

基本設計2回目レビュー後対応3.0h + 3.0h

詳細設計 2.5h + 2.5h + 8h
