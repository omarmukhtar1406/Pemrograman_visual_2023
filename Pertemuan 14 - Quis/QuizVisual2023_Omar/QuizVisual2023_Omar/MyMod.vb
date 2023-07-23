Module MyMod
    Public api_folder As String = "appakademik"
    Public dokter_api As String = "http://f0833877.xsph.ru/" & api_folder & "/dokter_api.php"
    Public dokter_baru As Boolean = False
    Public pasien_api As String = "http://f0833877.xsph.ru/" & api_folder & "/pasien_api.php"
    Public pasien_baru As Boolean = False
    Public Form1 As New Dokter
    Public Form2 As New Pasien
End Module
