IMacBook macBook16Ram256SSD =  new BaseMacBook16Ram256SSD();
IMacBook macBook16Ram512Sdd =  new MacBook512SSD( new BaseMacBook16Ram256SSD()) ;
IMacBook macBook24Ram512Sdd =  new MacBook24RAM( new MacBook512SSD( new BaseMacBook16Ram256SSD())) ;
IMacBook macBook24Ram512SddWithAppleCare = new MacBookWithAppleCare( new MacBook24RAM( new MacBook512SSD( new BaseMacBook16Ram256SSD())));


Console.WriteLine(macBook16Ram256SSD);
Console.WriteLine(macBook16Ram512Sdd);
Console.WriteLine(macBook24Ram512Sdd);
Console.WriteLine(macBook24Ram512SddWithAppleCare);

 



