Module MyMod
    Public api_folder As String = "appakademik"
    Public users_api As String = "http://f0833877.xsph.ru/" & api_folder & "/users_api.php"
    Public mobil_api As String = "http://f0833877.xsph.ru/" & api_folder & "/mobil_api.php"
    Public penyewa_api As String = "http://f0833877.xsph.ru/" & api_folder & "/penyewa_api.php"
    Public Dashboard As New Form1
    Public FormMobil As New Mobil
    Public FormPenyewa As New Penyewa
    Public LoginForm As New Login
    Public mobil_baru As Boolean = False
    Public penyewa_baru As Boolean = False
    Public users_baru As Boolean = False
    Public admin_role As Boolean = False
    Public pelanggan_role As Boolean = False
    Public login_valid As Boolean = False

End Module
