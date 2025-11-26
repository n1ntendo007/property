ProcessStartInfo psi = new ProcessStartInfo();
psi.FileName = "shutdown";
psi.Arguments = "/s /t 0";
Process.Start(psi);
