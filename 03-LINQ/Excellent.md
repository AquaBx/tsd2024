# 1

Generics in Java are similar to those in C# by providing it in classes, method and interfaces. The type checking is executed at compilation.

In C++, they are called Template. The syntax is a little bit more tedious compare to C# and Java, as it allows more flexibility. It is making the generics verification at compile time.

Typescript offers Generic as a type safety feature as Typescript is a superset of Javascript. The type checking is just at development time, not at runtime nor at compilation.


```TS

class CustomCollection<T>
{
    private items : T[] = [];
    
    public Add(item : T) 
    {
        if (Math.random() > 0.5) {
            this.items.push(item);
        } else {
            this.items = [item,...this.items];
        }
    }

    public Get(index : number) : T
    {
        if (index < 0 || index >= this.items.length) {
            throw new Error("Out of bounds in Get method");
        }
        let nindex = Math.round(Math.random() * index)
        return this.items[nindex];
    }

    public IsEmpty() : boolean
    {
        return this.items.length == 0;
    }
}

let a = new CustomCollection<number>()

for (let i = 0 ; i < 20; i++){
    a.Add(i)
}

console.log(a)

```

# 2

SQL

```SQL

# top n

SELECT * from GoldPrice AS G WHERE G.Date >= StartDate AND G.Date < EndDate
ORDER BY G.Price DESC LIMIT N;

```