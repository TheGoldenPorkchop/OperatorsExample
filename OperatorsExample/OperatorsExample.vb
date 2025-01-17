'Angel Nava
'Spring 2025
'RCET2265
'OperatorsExample
'https://github.com/TheGoldenPorkchop/OperatorsExample.git

Module OperatorsExample

    Sub Main()
        'sum operator
        Console.Write("5 + 3 = ") 'prints a string
        Console.WriteLine(5 + 3) 'prints the sum
        Console.WriteLine()

        'difference operator
        Console.Write("5 - 3 = ") 'prints a string
        Console.WriteLine(5 - 3) 'prints the difference
        Console.WriteLine()
        'product operator
        Console.Write("5 * 3 = ") 'prints a string
        Console.WriteLine(5 * 3) 'prints the product
        Console.WriteLine()

        'floating point quotient operator
        Console.Write("5 / 3 = ") 'prints a string
        Console.WriteLine(5 / 3) 'prints the quotient
        Console.WriteLine()

        'integer quotient operator
        Console.Write("5 \ 3 = ") 'prints a string
        Console.WriteLine(5 \ 3) 'prints the quotient
        Console.WriteLine()

        'modulus operator
        Console.Write("5 mod 3 = ") 'prints a string
        Console.WriteLine(5 Mod 3) 'prints the remainder
        Console.WriteLine()

        'exponent operator
        Console.Write("5 ^ 3 = ") 'prints a string
        Console.WriteLine(5 ^ 3) 'prints the exponent
        Console.WriteLine()

        'concatenation operator
        Console.Write("5" & " " & "+" & " " & "3" & " " & "=" & " ") 'concatenates sring string
        Console.WriteLine(5 + 3) 'prints the sum
        Console.WriteLine()
        Console.WriteLine("wake me up inside" & vbNewLine & "wake me up inside") 'adds a new line with concatenation
        Console.WriteLine(StrDup(20, "*")) 'duplicates the asteroids
    End Sub

End Module
