Imports System
Module calculadora_cientifica
    Sub Main(args As String())
        Dim ids(9) As Integer
        Dim operaciones(9) As String
        Dim primerosNumeros(9) As Double
        Dim segundosNumeros(9) As String
        Dim resultados(9) As Double
        Dim cantidad As Integer = 0
        Dim opcion As Integer
        '----------------------------------------------'
        '--|menu_principal_de_calculadora_cientifica|--'
        '----------------------------------------------'
        Do
            Console.WriteLine("menu principal de calculadora cientifica")
            Console.WriteLine("1) Suma")
            Console.WriteLine("2) Resta")
            Console.WriteLine("3) Multiplicacion")
            Console.WriteLine("4) Division")
            Console.WriteLine("5) Potencia")
            Console.WriteLine("6) Raiz cuadrada")
            Console.WriteLine("7) Funciones cientificas")
            Console.WriteLine("8) Historial de operaciones")
            Console.WriteLine("9) Salir")
            Console.Write("Seleccione una opcion: ")
            opcion = Convert.ToInt32(Console.ReadLine())
            Select Case opcion
                '----------'
                '--|suma|--'
                '----------'
                Case 1
                    If cantidad >= ids.Length Then
                        Console.WriteLine("El historial esta lleno.")
                    Else
                        Console.Write("Primer numero: ")
                        Dim numero1 As Double = Convert.ToDouble(Console.ReadLine())
                        Console.Write("Segundo numero: ")
                        Dim numero2 As Double = Convert.ToDouble(Console.ReadLine())
                        Dim resultado As Double = numero1 + numero2
                        ids(cantidad) = cantidad + 1
                        operaciones(cantidad) = "Suma"
                        primerosNumeros(cantidad) = numero1
                        segundosNumeros(cantidad) = numero2.ToString()
                        resultados(cantidad) = resultado
                        Console.WriteLine("Resultado: " & resultado)
                        cantidad += 1
                    End If
                '-----------'
                '--|resta|--'
                '-----------'
                Case 2
                    If cantidad >= ids.Length Then
                        Console.WriteLine("El historial esta lleno.")
                    Else
                        Console.Write("Primer numero: ")
                        Dim numero1 As Double = Convert.ToDouble(Console.ReadLine())
                        Console.Write("Segundo numero: ")
                        Dim numero2 As Double = Convert.ToDouble(Console.ReadLine())
                        Dim resultado As Double = numero1 - numero2
                        ids(cantidad) = cantidad + 1
                        operaciones(cantidad) = "Resta"
                        primerosNumeros(cantidad) = numero1
                        segundosNumeros(cantidad) = numero2.ToString()
                        resultados(cantidad) = resultado
                        Console.WriteLine("Resultado: " & resultado)
                        cantidad += 1
                    End If
                '--------------------'
                '--|multiplicacion|--'
                '--------------------'
                Case 3
                    If cantidad >= ids.Length Then
                        Console.WriteLine("El historial esta lleno.")
                    Else
                        Console.Write("Primer numero: ")
                        Dim numero1 As Double = Convert.ToDouble(Console.ReadLine())
                        Console.Write("Segundo numero: ")
                        Dim numero2 As Double = Convert.ToDouble(Console.ReadLine())
                        Dim resultado As Double = numero1 * numero2
                        ids(cantidad) = cantidad + 1
                        operaciones(cantidad) = "Multiplicacion"
                        primerosNumeros(cantidad) = numero1
                        segundosNumeros(cantidad) = numero2.ToString()
                        resultados(cantidad) = resultado
                        Console.WriteLine("Resultado: " & resultado)
                        cantidad += 1
                    End If
                '--------------'
                '--|division|--'
                '--------------'
                Case 4
                    If cantidad >= ids.Length Then
                        Console.WriteLine("El historial esta lleno.")
                    Else
                        Console.Write("Primer numero: ")
                        Dim numero1 As Double = Convert.ToDouble(Console.ReadLine())
                        Console.Write("Segundo numero: ")
                        Dim numero2 As Double = Convert.ToDouble(Console.ReadLine())
                        If numero2 = 0 Then
                            Console.WriteLine("No se puede dividir entre cero.")
                        Else
                            Dim resultado As Double = numero1 / numero2
                            ids(cantidad) = cantidad + 1
                            operaciones(cantidad) = "Division"
                            primerosNumeros(cantidad) = numero1
                            segundosNumeros(cantidad) = numero2.ToString()
                            resultados(cantidad) = resultado
                            Console.WriteLine("Resultado: " & resultado)
                            cantidad += 1
                        End If
                    End If
                '--------------'
                '--|potencia|--'
                '--------------'
                Case 5
                    If cantidad >= ids.Length Then
                        Console.WriteLine("El historial esta lleno.")
                    Else
                        Console.Write("Base: ")
                        Dim numero1 As Double = Convert.ToDouble(Console.ReadLine())
                        Console.Write("Exponente: ")
                        Dim numero2 As Double = Convert.ToDouble(Console.ReadLine())
                        Dim resultado As Double = Math.Pow(numero1, numero2)
                        ids(cantidad) = cantidad + 1
                        operaciones(cantidad) = "Potencia"
                        primerosNumeros(cantidad) = numero1
                        segundosNumeros(cantidad) = numero2.ToString()
                        resultados(cantidad) = resultado
                        Console.WriteLine("Resultado: " & resultado)
                        cantidad += 1
                    End If
                '-------------------'
                '--|raiz_cuadrada|--'
                '-------------------'
                Case 6
                    If cantidad >= ids.Length Then
                        Console.WriteLine("El historial esta lleno.")
                    Else
                        Console.Write("Numero: ")
                        Dim numero As Double = Convert.ToDouble(Console.ReadLine())
                        If numero < 0 Then
                            Console.WriteLine("No se puede calcular la raiz cuadrada de un numero negativo.")
                        Else
                            Dim resultado As Double = Math.Sqrt(numero)
                            ids(cantidad) = cantidad + 1
                            operaciones(cantidad) = "Raiz cuadrada"
                            primerosNumeros(cantidad) = numero
                            segundosNumeros(cantidad) = "N/A"
                            resultados(cantidad) = resultado
                            Console.WriteLine("Resultado: " & resultado)
                            cantidad += 1
                        End If
                    End If
                '---------------------------'
                '--|funciones_cientificas|--'
                '---------------------------'
                Case 7
                    If cantidad >= ids.Length Then
                        Console.WriteLine("El historial esta lleno.")
                    Else
                        Dim opcionCientifica As Integer
                        Console.WriteLine("funciones cientificas")
                        Console.WriteLine("1) Seno")
                        Console.WriteLine("2) Coseno")
                        Console.WriteLine("3) Tangente")
                        Console.WriteLine("4) Logaritmo")
                        Console.WriteLine("5) Logaritmo natural")
                        Console.WriteLine("6) Valor absoluto")
                        Console.WriteLine("7) Regresar")
                        Console.Write("Seleccione una opcion: ")
                        opcionCientifica = Convert.ToInt32(Console.ReadLine())
                        Select Case opcionCientifica
                            '----------'
                            '--|seno|--'
                            '----------'
                            Case 1
                                Console.Write("Angulo en grados: ")
                                Dim numero As Double = Convert.ToDouble(Console.ReadLine())
                                Dim radianes As Double = numero * Math.PI / 180
                                Dim resultado As Double = Math.Sin(radianes)
                                ids(cantidad) = cantidad + 1
                                operaciones(cantidad) = "Seno"
                                primerosNumeros(cantidad) = numero
                                segundosNumeros(cantidad) = "N/A"
                                resultados(cantidad) = resultado
                                Console.WriteLine("Resultado: " & resultado)
                                cantidad += 1
                            '------------'
                            '--|coseno|--'
                            '------------'
                            Case 2
                                Console.Write("Angulo en grados: ")
                                Dim numero As Double = Convert.ToDouble(Console.ReadLine())
                                Dim radianes As Double = numero * Math.PI / 180
                                Dim resultado As Double = Math.Cos(radianes)
                                ids(cantidad) = cantidad + 1
                                operaciones(cantidad) = "Coseno"
                                primerosNumeros(cantidad) = numero
                                segundosNumeros(cantidad) = "N/A"
                                resultados(cantidad) = resultado
                                Console.WriteLine("Resultado: " & resultado)
                                cantidad += 1
                            '--------------'
                            '--|tangente|--'
                            '--------------'
                            Case 3
                                Console.Write("Angulo en grados: ")
                                Dim numero As Double = Convert.ToDouble(Console.ReadLine())
                                Dim radianes As Double = numero * Math.PI / 180
                                Dim resultado As Double = Math.Tan(radianes)
                                ids(cantidad) = cantidad + 1
                                operaciones(cantidad) = "Tangente"
                                primerosNumeros(cantidad) = numero
                                segundosNumeros(cantidad) = "N/A"
                                resultados(cantidad) = resultado
                                Console.WriteLine("Resultado: " & resultado)
                                cantidad += 1
                            '---------------'
                            '--|logaritmo|--'
                            '---------------'
                            Case 4
                                Console.Write("Numero: ")
                                Dim numero As Double = Convert.ToDouble(Console.ReadLine())
                                If numero <= 0 Then
                                    Console.WriteLine("El numero debe ser mayor que cero.")
                                Else
                                    Dim resultado As Double = Math.Log10(numero)
                                    ids(cantidad) = cantidad + 1
                                    operaciones(cantidad) = "Logaritmo"
                                    primerosNumeros(cantidad) = numero
                                    segundosNumeros(cantidad) = "N/A"
                                    resultados(cantidad) = resultado
                                    Console.WriteLine("Resultado: " & resultado)
                                    cantidad += 1
                                End If
                            '-----------------------'
                            '--|logaritmo_natural|--'
                            '-----------------------'
                            Case 5
                                Console.Write("Numero: ")
                                Dim numero As Double = Convert.ToDouble(Console.ReadLine())
                                If numero <= 0 Then
                                    Console.WriteLine("El numero debe ser mayor que cero.")
                                Else
                                    Dim resultado As Double = Math.Log(numero)
                                    ids(cantidad) = cantidad + 1
                                    operaciones(cantidad) = "Logaritmo natural"
                                    primerosNumeros(cantidad) = numero
                                    segundosNumeros(cantidad) = "N/A"
                                    resultados(cantidad) = resultado
                                    Console.WriteLine("Resultado: " & resultado)
                                    cantidad += 1
                                End If
                            '--------------------'
                            '--|valor_absoluto|--'
                            '--------------------'
                            Case 6
                                Console.Write("Numero: ")
                                Dim numero As Double = Convert.ToDouble(Console.ReadLine())
                                Dim resultado As Double = Math.Abs(numero)
                                ids(cantidad) = cantidad + 1
                                operaciones(cantidad) = "Valor absoluto"
                                primerosNumeros(cantidad) = numero
                                segundosNumeros(cantidad) = "N/A"
                                resultados(cantidad) = resultado
                                Console.WriteLine("Resultado: " & resultado)
                                cantidad += 1
                            '--------------'
                            '--|regresar|--'
                            '--------------'
                            Case 7
                                Console.WriteLine("Regresando al menu principal.")
                            Case Else
                                Console.WriteLine("Opcion no valida.")
                        End Select
                    End If
                '------------------------------'
                '--|historial_de_operaciones|--'
                '------------------------------'
                Case 8
                    If cantidad = 0 Then
                        Console.WriteLine("No existen operaciones en el historial.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Operacion: " & operaciones(i) & " | Primer numero: " & primerosNumeros(i) & " | Segundo numero: " & segundosNumeros(i) & " | Resultado: " & resultados(i))
                        Next
                    End If
                '------------------------------'
                '--|salir_del_menu_principal|--'
                '------------------------------'
                Case 9
                    Console.WriteLine("Gracias por utilizar Calculadora Cientifica.")
                Case Else
                    Console.WriteLine("Opcion no valida.")
            End Select
        Loop While opcion <> 9
    End Sub
End Module