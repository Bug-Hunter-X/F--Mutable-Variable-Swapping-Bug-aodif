let x, y = 10, 20

let swap (x, y) =
    y, x

let x1, y1 = swap (x, y)
printf "%d %d" x1 y1