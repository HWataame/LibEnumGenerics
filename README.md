# LibEnumGenerics

## 概要 / Overview
C#の数値とジェネリック引数の列挙型の値を変換するライブラリです / The library converts between numeric and generics argument enum value in C#.

## 使用方法 / Usage
![使用方法 / Usage](https://github.com/user-attachments/assets/2fdf628f-ed61-4819-8a66-26846937d539)

### 数値をジェネリック引数の列挙型の値に変換する / Cast number to generics argument enum value
```csharp
// where T : unmanaged, Enum
T enumValue = Enum<T>.ToEnum(intValue);
```

### ジェネリック引数の列挙型の値を整数値に変換する / Cast generics argument enum value to integer value
```csharp
// where T : unmanaged, Enum
T intValue = Enum<T>.ToInt32(enumValue);
```

## 導入方法 / English "How to use" is below this
### 共通
- [Releases](https://github.com/HWataame/LibEnumGenerics/releases)から最新版(LibEnumGenerics_xxxxxx_xxxx.zip)をダウンロードする / Download latest version (LibEnumGenerics_xxxxxx_xxxx.zip) from [Releases](https://github.com/HWataame/LibEnumGenerics/releases)

### 通常のC#プロジェクト(Visual Studio 2022)の場合
1. (任意)「Documents」フォルダ内にある、お好みの言語名のフォルダーの「LibEnumGenerics.xml」を「LibEnumGenerics.dll」と同じフォルダーにコピーする
2. ライブラリを参照したいプロジェクトを右クリックし、「追加(D)」から「プロジェクト参照(R)...」を選択する
3. 「参照マネージャー」ウィンドウの下部にある「参照(B)...」ボタンをクリックし、「LibEnumGenerics.dll」を選択して追加する
4. 「参照」の項目内の「LibEnumGenerics.dll」のチェックが入れ、下部のOKボタンを押す

### Unityのプロジェクトの場合
1. 「LibEnumGenerics.dll」を導入するプロジェクトのAssets以下に追加する
2. (任意)「Documents」フォルダ内にある、お好みの言語名のフォルダーの「LibEnumGenerics.xml」を手順1でdllを追加した場所にコピーする
3. (必要に応じて)ライブラリを参照したいAssemblyDefinitionAssetの「Override References」を有効にし、「Assembly References」の項目に「LibEnumGenerics.dll」を追加する

## How to use / 日本語の「導入方法」は上にあります
### Case A: In C# project(with Visual Studio 2022)
1. (Optional) Copy "LibEnumGenerics.xml" from the folder named after the language you want to use in the "Documents" folder to the same folder as "LibEnumGenerics.dll"
2. Right-click on the project to which you want to refer to the library, select "Add" and then "Project References..."
3. Click on the "Browse..." button at the bottom of the "Reference Manager" and select "LibEnumGenerics.dll"
4. Check "LibEnumGenerics.dll" in the "Browse" section and press "OK" button

### Case B: In Unity project
1. Add "LibEnumGenerics.dll" under "Assets" folder in the project
2. (Optional) Copy "LibEnumGenerics.xml" from the folder named after the language you want to use in the "Documents" folder to the same folder as add "LibEnumGenerics.dll" in step 1
3. (If needed) Enable "Override References" in your AssemblyDefinitionAsset and add "LibEnumGenerics.dll" to "Assembly References"

## 詳しい仕様 / Features
### ジェネリック引数の列挙型の制約 / Constraints of generics argument

`where T : unmanaged, Enum`

(C#のソースで作成した列挙型はこの条件を満たします / Created from `enum MyEnum { ... }` in C# source satisfies these constraints)

### 使用可能な型 / Types that can be using
- 数値 → 列挙型の値 / Number to enum value

`byte` `sbyte` `ushort` `short` `uint` `int` `ulong` `long`

`float` `double` (`long`型にキャストするヘルパー / Helper of cast to `long` before cast to enum value)

- 列挙型の値の値 → 整数値 / Enum value to Integer

`byte` `sbyte` `ushort` `short` `uint` `int` `ulong` `long`

## ライセンス / License
MITライセンスです / Using "MIT License"

[LISENCE](/LICENSE)
