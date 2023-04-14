Public Interface IGenericReposotory(Of Entity As Class)
    Function GetAll() As IEnumerable(Of Entity)
    Function Add(entity As Entity) As Integer
    Function Edit(entity As Entity) As Integer
    Function Delete(Id As Integer) As Integer
End Interface
