# 水星工程科技有限公司 - 後端工程師

此 Github 是存放相關考題內容，請面試者下載相關考題所需要的檔案，考試完成請直接透過 Email 告知你的 GitHub 的位置

考試說明：(測試前 10 分鐘會寄到您信箱)

請盡可能完成您考題，本考題的內容最主要是在了解您對於

（1）. SQL SERVER / Stored Procedure / JSON 與 CURD 的應用<BR>
（2）. Visual Studio 操作<BR>
（3）. .NET Core 8 Web API MVC 技術的應用<BR>
（4）. GitHub 版控應用<BR>

以上這些都是開發上基本的應用，請盡量完成。評分標準在於你完成度，所謂的完成度是您必須要將以下的項目來完成撰寫，目錄 TSQLScript 裡面提供了相關考試要用的 Table 與 Stored Procedure 請使用目錄內的 TSQL 語法來完成考試<BR><BR>

## 繳交的考試內容必須要有以下的程式

1. 提供 Visual Studio for WebAPI 專案內容<BR>
   1.1 你的專案一開始就要與 GitHub 來進行串接並有做到相關的版控，例如 develop , main , remotes/origin 等版控方式<BR>
   1.2 必須連線到 SQL SERVER 來執行與運行 Exec [Stored Procedure] 並傳入 JSON <BR>
   1.3 取得 JSON 後展示在 WebAPI 測試頁面上 <BR>
   1.4 你的程式必須產生相關 CRUD 的 JSON 來與 SQL SERVER 進行相關存取動作<BR>
   1.5 SQL SERVER 只能用 JSON 並解析出相關資料並做出 CRUD 等相關功能<br>

2. 你的 SQL SERVER 要有以下內容<BR>
   2.1 你必須撰寫 Stored Procedure 來為 Myoffice_ACPD 來進行相關 CRUD 的動作<BR>
   2.2 每一個 Stored Procedure 資料的處理都必須要透過 JSON 的方式來進行相關 CRUD 的動作與行為<BR>
   2.3 執行的過程中請使用 usp_AddLog 來記錄你 sp 的執行過程<BR>
   2.4 寫入 Myoffice_ACPD 必須配合 [NEWSID] 這個 Stored Procedure 來為 Myoffice_ACPD 做為索引的來源<BR>
   2.5 所有對 SQL CRUD 一概使用 SQL 內相關 JSON 函式<BR>
   2.6 請備份你的 SQL Server Back 到 GitHub 上以供下載<BR>

3. WebAPI 必須都要在 swagger 展示與執行<BR>
   3.1 執行時必須要在 swagger 上執行<BR>
   3.2 swagger 必須要能夠執行 CRUD 等相關動作<br>

4. 考試與繳交的技術請以考題的規定，脫離了考題與要求的展示內容，也請不要用 AI 來完成你的專案，一概不及格。<br><br><br>

當你看完以上的基本的考試內容後，請確定你是否可以在時間內完成，如果在時間內「無法完成」請來信 延長考試 時間。<BR><BR>

## 【繳交時請再三確定，免得你浪費了考試時間最後不及格】

1. GitHub 是否有你的建立與處理的過程，會用 develop , main , remotes/origin 等版控方式<BR>
2. 你的 Visual Studio 專案要有與 SQL Connection 並用 JSON 的方式來執行 Exec [Stored Procedure] json <BR>
3. 請再三確定你的 Visual Studio 專案執行 swagger 必須要能夠做到相關 CRUD 的功能。<BR>
4. 請備份你的資料庫並上傳到 GitHub ，以便提供本公司了解到你對於後端資料庫應用與 Visual Studio 專案是否都可以寫的清楚執行上都沒有問題。<BR><BR>

### 【建議與其他說明】

- 本考題內容與本公司的專案沒有任何一點關係，只是了解你的基本能力與技術應用而已，如果你認定「這考題內容是在幫助本公司寫專案繳交作業」，你可以放棄此次考試的內容，別浪費你的時間!!<BR>
- GitHub 只是要了解你有沒有「基本版控能力」而已，拿 main 去做 develop 分支，然後再 merge 到 main 這樣的基本操作而已，這不用花費五分鐘的時間，寫完程式全部提交到 GitHub 就這樣子而已，請不要想的太複雜!!<BR>

- 請再三確定你的 Visual Studio 專案執行 swagger 必須要能夠做到相關 CRUD 的功能，不要傳入 JSON 之後連 資料 都沒有寫進去，請記得要用 NewSID 來做為索引。<BR>

- 本公司現有開發的專案都是以「前/後 端分離」了，不需要一個人包辦前後端的應用開發。只想要了解你對於後端的能力與技術應用，以現有的技術 SQL SERVER 都己經可以接 JSON 了，SP 與 SP 之間的互動也都是以 JSON 來進行，所以你不需要使用 Entity Framework Core 來做 SQL SERVER Stored Procedure 的處理與動作，以你所寫的 Stored Procedure + OpenJSON 等相關函式來完成 CRUD 即可<BR>

<BR><BR>

## 水星防火工程顧問有限公司 - 簡介

本公司是一家以「台灣的消防法規」專業顧問公司，你不需要懂「消防法規」本公司有相關同仁會告訴你「需求是什麼」再由你以「需求面」來提供給本公司相關技術開發上的專業。<br><br>

本公司專案是以「開發產品為導向」專案都是「前/後 端分離」大量使用 json 做為資料的交換，所有的動作都與 json 息息相關，沒有必要在做 CRUD 還要從 .NET Core 找了一堆 Table 資料再來進行相關的 Model、Repositorys 的處理，本公司除了基本的 .net core 之外還有與 iOT、WebSorck、MoDBUS 等相關處理，還有相關硬體訊號 PLC 點位的了解與整合處理等... <br>

以上大部份都是後端工程師在做的事情，另外你的程式運行會在 Linux、Windows、Docker 等相關作業系統上，所以「程式與資料庫」拆開處理與撰寫才不會 "開發時邏輯打結"，產生什麼 json 都是事先談好才來做開發。 希望你是會喜歡寫文件(Word)的工程師，本公司是開發「產品」必須要有標準系統開發文件的規格，本公司會提供給你相關的格式，撰寫完並進行審議（討論與溝通）以便提供給其他同仁一同來了解 系統開發的前因後果 ，才能夠使得「產品」繼續發展下去。

以下項目都是本公司會處理與整合的項目..<BR>

Docker<BR>
Linux<BR>
Raspberry Pi 5 、 ESP32<BR>
Postgres <BR>
influxDB <BR>
Mongo <BR>
.NET 8 for Windows , Linux <BR>
