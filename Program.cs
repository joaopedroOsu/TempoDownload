double mb, mbps, download;
Console.WriteLine("--- Tempo de Download ---");
Console.Write("Tamanho do arquivo em MB........:");
mb = Convert.ToDouble(Console.ReadLine());
Console.Write("Velocidade da conexão em Mbps...:");
mbps = Convert.ToDouble(Console.ReadLine());
download = mb * 8 / mbps / 60;

Console.WriteLine($"\nTempo estimado de download: {download:N1} minutos");
