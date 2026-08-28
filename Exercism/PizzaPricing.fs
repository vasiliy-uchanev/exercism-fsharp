module PizzaPricing

type Pizza =
    | Margherita
    | Caprese
    | Formaggio
    | ExtraSauce of Pizza
    | ExtraToppings of Pizza

let rec pizzaPrice (pizza: Pizza) : int =
    match pizza with
    | Margherita -> 7
    | Caprese -> 9
    | Formaggio -> 10
    | ExtraSauce x -> 1 + pizzaPrice x
    | ExtraToppings x -> 2 + pizzaPrice x

let additionalFee (pizzas: Pizza list) : int =
    match pizzas with
    | [ _ ] -> 3
    | [ _; _ ] -> 2
    | _ -> 0

let orderPrice (pizzas: Pizza list) : int =
    List.sumBy pizzaPrice pizzas + additionalFee pizzas
