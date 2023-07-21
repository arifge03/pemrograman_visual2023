Module MyMod
    Public api_folder As String = "appakademik"
    Public users_api As String = "http://f0833874.xsph.ru/" & api_folder & "/users_api.php"
    Public kamar_api As String = "http://f0833874.xsph.ru/" & api_folder & "/kamar_api.php"
    Public penyewa_api As String = "http://f0833874.xsph.ru/" & api_folder & "/penyewa_api.php"
    Public user_api As String = "http://f0833874.xsph.ru/" & api_folder & "/user_api.php"
    Public Dashboard As New Form1
    Public FormKamar As New Kamar
    Public FormPenyewa As New FormPenyewa
    Public LoginForm As New Login
    Public kamar_baru As Boolean = False
    Public penyewa_baru As Boolean = False
    Public user_baru As Boolean = False
    Public admin_role As Boolean = False
    Public penyewa_role As Boolean = False
    Public login_valid As Boolean = False

End Module
