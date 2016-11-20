Module ModProductos
    Structure productos
        <VBFixedString(25)> Dim NombreProducto As String
        <VBFixedString(5)> Dim PrecioProducto As String
        <VBFixedString(25)> Dim CategoriaProducto As String

    End Structure
    Public prod As New productos
End Module
