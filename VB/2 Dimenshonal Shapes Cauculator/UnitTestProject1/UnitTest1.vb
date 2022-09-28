Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub TestMethod1()
        Dim F1 As New Form1
        Assert.Equals(F1.Area(4, 5), 20)
    End Sub

End Class



'A forest quite In a close distance a grope of chilldren play under a ginomous willow tree. the willow subenly the tree fell 
'most likly because of the termights