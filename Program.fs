open System

let funcion (x) :float =
    (0.5 - (x*(System.Math.E))**(((-1.0)*x)**(2.0)))

let mutable a:float = 0.0
let mutable b:float = 2.0
let mutable x1:float = a
let mutable x2:float = b
let mutable iter = 0
let R:float = (((-1.0)+((5.0)**(0.5)))/(2.0))
let mutable Break:bool = true
let mutable f1:float = 0.0
let mutable f2:float = 0.0
while (Break=true) do
    if ((System.Math.Round(a,6)) = (System.Math.Round(b,6))) then
        Break <- false
    f1 <- funcion (x1)
    f2 <- funcion (x2)
    if (f1>f2) then
        a <- a
        b <- x2
    elif (f1<f2) then
        a <- x1
        b <- b
    else
        Break <- false
    x1 <- a + (1.0 - R)*(b-a)
    x2 <- a + R*(b-a)
    iter <- iter + 1
    printfn "iteraciones: %i"  iter
    printfn "valor en x: %f" x1
    printfn "valor en f(x): %f" f1

Console.ReadKey() |> ignore