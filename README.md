# AR-HHKB
無刻印HHKBの配列をARでわかりやすく表現  

![demo](https://user-images.githubusercontent.com/50506482/90257849-a98e2000-de82-11ea-983e-a435b23f6054.gif)

> 動画のフルバージョン: https://twitter.com/dameganeo/status/1294252868187324416
## Description
UnityのAR FoundationのObject Trackingを使いHHKBを認識させ、その上にキー配列を表示しています

## Usage
1. このリポジトリをクローンします
```zsh
git clone https://github.com/DuGlaser/AR-HHKB.git
```

2. 次にお手元に無刻印HHKBを用意します
3. ARKit Scannerを使ってHHKBをスキャンします
> https://developer.apple.com/documentation/arkit/scanning_and_detecting_3d_objects
4. Unityでこのプロジェクトを開きます
5. MainSceneのAR Session OriginにあるTracking Objectに先ほどスキャンしたHHKBをセットします
6. ビルドをすれば完了です
