# Visual Studio 2022 基本講座
LinkedInラーニングの「Visual Studio 2022 基本講座」コース用のリポジトリです。このコースは [LinkedInラーニング][lil-course-url]で視聴できます。

![Visual Studio 2022 基本講座][lil-thumbnail-url] 
Visual Studio 2022は.NET開発のための最新のIDEです。64bit化されこれまで以上に快適に開発が行えるようになりました。このコースではVisual Studio 2022の基本から機械学習を利用した最新の機能まで幅広く紹介します。豊富な補完機能を備えたコードエディターの活用や、デバッグを効率よく進めることができるウィンドウの表示、便利なオプションなどをわかりやすく解説します。このコースを学習することでVisual StudioがどれほどパワフルなIDEかを知ることができるでしょう。

## リポジトリの使い方
このリポジトリには必要に応じてブランチが設けられています。ブランチのポップアップメニューを使用して、使用するブランチに切り替えたあとにコースを視聴してください。またURLに`「/tree/ブランチ名」`を追加することで、アクセスしたいブランチに移動することも可能です。

## ブランチ
ブランチはレッスンごとに作成されている場合があります。その場合はブランチ名に`「章番号_レッスン番号」`が付けられています。例えば`「02_03」`という名前のブランチは、2章の上から3番目のレッスン用のブランチとなります。

レッスン前と後のコードを格納しているブランチもあります。該当ブランチには「開始時」（beginning）を表す`「b」`と、「終了時」（ending）を表す`「e」` がブランチ名についています。`「b」`のブランチにはレッスン開始時点のコードが、`「e」`のブランチにはレッスン終了時点のコードが格納されています。また「main」のブランチにはコードの最終形が格納されています。

ファイルに変更を加えた後に、エクササイズファイルのブランチを次のブランチに切り替えたさい、次のようなメッセージが表示されることがあります。

    error: Your local changes to the following files would be overwritten by checkout:        [files]
    Please commit your changes or stash them before you switch branches.
    Aborting

この問題を解決するには：
	
    次のコマンドで変更を加えます：git add .
	次のコマンドで変更をコミットします：git commit -m "some message"

## インストール
1. エクササイズファイルを使用するには`Visual Studio 2022以降`がインストールされている必要があります
	- [Visual Studio](https://visualstudio.microsoft.com/ja/downloads/)
2. リポジトリをWindows PCにクローンしてください。
3. フォルダーの中にある`ソリューションファイル（拡張子が.sln）`をVisual Studioで開くことで実行することができます。

### インストラクター

**西村 誠**

_プログラマー、Microsoft MVP_

この講師の他のコースを視聴する：[LinkedInラーニング](https://www.linkedin.com/learning/instructors/13315091)

[lil-course-url]: https://www.linkedin.com/learning/visual-studio-2022-essential-training
[lil-thumbnail-url]: https://media.licdn.com/dms/image/D560DAQEV4eNFQTE79A/learning-public-crop_675_1200/0/1681923716963?e=2147483647&v=beta&t=pJ9tRy4nzRYBpLtFQLwLmzLg5Fy7SRUYhsr7sjEJ-kA
