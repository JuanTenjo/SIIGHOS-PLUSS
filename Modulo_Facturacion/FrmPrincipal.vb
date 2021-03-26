Imports System.Data.OleDb

Public Class FrmPrincipal


    Public Function BuscarDatosConexion()
        Try


            Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\SIIGHOSPLUS\LogPlusAdysnet.LogSip;Jet OLEDB:Database Password=SIIGHOS33")

            con.Open()

            Dim Consulta As String = "SELECT * FROM [Local registro del usuario]"

            Dim dr As OleDbCommand = New OleDbCommand(Consulta, con)
            Dim drr As OleDbDataReader = dr.ExecuteReader()

            drr.Read()

            ModuloVariablesAplicacion.NomServi = drr("NomServi") 'Nombre Servidor
            ModuloVariablesAplicacion.NomUsar = drr("NomUsar") 'Usuario Servidor
            ModuloVariablesAplicacion.NombreUsuarioLogeado = drr("NombreUsar") 'Usualio Logeado
            ModuloVariablesAplicacion.PassWusa = drr("PassWusa") 'PassServidor
            ModuloVariablesAplicacion.CodigUsar = drr("CodigUsar") 'Codigo usuario logeado
            ModuloVariablesAplicacion.NivelPermiso = drr("NivelPermiso") 'Nivel de permiso
            ModuloVariablesAplicacion.NombreEmpresa = drr("NombreEmpresa")
            'ConexionBaseDeDatos.cn.ConnectionString = "Data Source=" & ModuloVariablesAplicacion.NomServi & ";Initial Catalog=BDADYSNET;Integrated Security=True"
            ConexionBaseDeDatos.cn.ConnectionString = ("Data Source=" & ModuloVariablesAplicacion.NomServi & ";Initial Catalog=BDADYSNET;User ID=" & ModuloVariablesAplicacion.NomUsar & ";Password=" & ModuloVariablesAplicacion.PassWusa)
            ModuloVariablesAplicacion.CadenaConexion = ConexionBaseDeDatos.cn.ConnectionString
            '  ModuloVariablesAplicacion.VerNatiClien = drr("VerNatiClien")



            'Select Case (ModuloVariablesAplicacion.VerNatiClien)
            '    Case "9"
            '        ModuloVariablesAplicacion.conexion = "Provider=sqloledb;Data source= " + ModuloVariablesAplicacion.NomServi + ";Initial Catalog=ACDATOXPSQL;User ID=" + ModuloVariablesAplicacion.NomUsar + ";Password=" + ModuloVariablesAplicacion.PassWusa + ""

            '    Case "10"
            '        ModuloVariablesAplicacion.conexion = "Provider=SQLNCLI10;Data source= " + ModuloVariablesAplicacion.NomServi + ";Initial Catalog=ACDATOXPSQL;User ID=" + ModuloVariablesAplicacion.NomUsar + ";Password=" + ModuloVariablesAplicacion.PassWusa + ";DataTypeCompatibility = 80"

            '    Case "11"
            '        ModuloVariablesAplicacion.conexion = "Provider=SQLNCLI11;Data source= " + ModuloVariablesAplicacion.NomServi + ";Initial Catalog=ACDATOXPSQL;User ID=" + ModuloVariablesAplicacion.NomUsar + ";Password=" + ModuloVariablesAplicacion.PassWusa + ";DataTypeCompatibility = 80"

            '    Case Else
            '        ModuloVariablesAplicacion.conexion = "Provider=sqloledb;Data source= " + ModuloVariablesAplicacion.NomServi + ";Initial Catalog=ACDATOXPSQL;User ID=" + ModuloVariablesAplicacion.NomUsar + ";Password=" + ModuloVariablesAplicacion.PassWusa + ";"
            'End Select


            con.Close()

        Catch ex As Exception
            Titulo01 = "Control de errores de ejecución"
            Informa = "Lo siento pero se ha presentado un error " & Chr(13) & Chr(10)
            Informa += "En la conexion del servidor" & Chr(13) & Chr(10)
            Informa += "Mensaje del error: " & ex.Message
            MessageBox.Show(Informa, Titulo01, MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Function

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub ProvedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProvedoresToolStripMenuItem.Click
        Provedores.ShowDialog()
    End Sub

    Private Sub ContratosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ContratosToolStripMenuItem1.Click
        Contratos.ShowDialog()
    End Sub

    Private Sub NotaCreditoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotaCreditoToolStripMenuItem.Click
        NotaCredito.ShowDialog()
    End Sub

    Private Sub RemisionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemisionesToolStripMenuItem1.Click
        Remisiones.ShowDialog()
    End Sub

    Private Sub PagosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagosToolStripMenuItem1.Click
        Pagos.ShowDialog()
    End Sub

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BuscarDatosConexion()
    End Sub

    Private Sub FacturasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FacturasToolStripMenuItem1.Click
        Facturas.ShowDialog()
    End Sub


    Private Sub ProducServiciosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProducServiciosToolStripMenuItem.Click
        CodigosProductos.ShowDialog()
    End Sub

    Private Sub NotaDebitoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotaDebitoToolStripMenuItem.Click
        NotaDebito.ShowDialog()
    End Sub
End Class
