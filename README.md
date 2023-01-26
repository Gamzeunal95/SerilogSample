# SerilogConsole

# Project 1 - SeriLogConsole
- Serilog [siteden] (https://datalust.co/download) install edildi.

- Ve kurulumu yapıldı. Vermiş olduğu URl'den takip edeceğiz. `http://localhost:5341/`

- Aşağıdaki paketler install edildi. Console Projesi üzerinde deneme yapılacağı için Console paketi install edildi.
  - Serilog.Sinks.File
  - Serilog.Sinks.Console
  - Serilog.Sinks.Seq  -> bu paketi install etmemiz ve program.cs dosyasına ıp/port belirtildiği için Seq Web sayfasında logları görebiliyoruz.

# Project 2 - SerilogWebApiEntegrasyonu
- Aşağıdaki paketler install edildi.
	- Serilog.AspNetCore
	- Serilog.Sinks.Seq
- appsettings.json dosyasında gerekli configuration'lar yapıldı.
	- API KEY olusturuldu. Seq Setting kısmından bunu da bu appsettings.json dosyasına ekliyoruz.


![APIKeyAlmakİçin](https://user-images.githubusercontent.com/101207897/214882672-609578fb-aecf-4f0d-8360-13e3413b51fc.png)

- [Dokuman](https://github.com/serilog/serilog-aspnetcore)
