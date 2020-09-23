Imports System.Web.Mvc

Namespace Controller
    Public Class ProductController
        Inherits Controller

        ' GET: Product
        Function Index() As ActionResult
            Return View()
        End Function
    End Class
End Namespace