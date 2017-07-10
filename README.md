# Planet-Spaceship
My first dot net program
## Exercise

In the `Main` method, place the following code

```cs
List<string> planetList = new List<string>(){"Mercury", "Mars"};
```

1. `Add()` Jupiter and Saturn at the end of the list.
1. Create another `List` that contains that last two planet of our solar system.
1. Combine the two lists by using `AddRange()`.
1. Use `Insert()` to add Earth, and Venus in the correct order.
1. Use `Add()` again to add Pluto to the end of the list.
1. Now that all the planets are in the list, slice the list using `GetRange()` in order to extract the rocky planets into a new list called `rockyPlanets`.
1. Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the `Remove()` method to eliminate it from the end of `planetList`.

## Iterating over planets

> **Ref:** [List of Solar System probes](https://en.wikipedia.org/wiki/List_of_Solar_System_probes)

1. Create another list containing dictionaries. Each dictionary will hold the name of a spacecraft that we have launched, and the names of the planet that it has visited.
1. Iterate over your list of planets from above, and inside that loop, iterate over the list of dictionaries. Write to the console, for each planet, which satellites have visited which planet.

```
