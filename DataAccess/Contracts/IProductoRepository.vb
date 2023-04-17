Public Interface IProductoRepository
    Inherits IGenericReposotory(Of Producto)

    Function GetAllServices() As Task(Of IEnumerable(Of Producto))

End Interface
