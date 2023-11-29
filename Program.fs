// Define the discriminated union for genres
type Genre =
    | Sport
    | Fantasy
    | Thriller
    | Comedy
    | Drama
    | Horror

// Define the "Director" record type
type Director = {
    Name: string
    Movies: int
}

// Define the "Movie" record type
type Movie = {
    Name: string
    RunningLength: int
    Genre: Genre
    Director: Director
    IMDBRating: float
}


// Create movie instances
let movies = [
    { Name = "CODA"; RunningLength = 111; Genre = Drama; Director = { Name = "Sian Heder"; Movies = 9 }; IMDBRating = 8.1 }
    { Name = "Don't Look Up"; RunningLength = 138; Genre = Comedy; Director = { Name = "Adam Mckay"; Movies = 27 }; IMDBRating = 7.2 }
    { Name = "Belfast"; RunningLength = 98; Genre = Comedy; Director = { Name = "Kenneth Branagh"; Movies = 23 }; IMDBRating = 7.3 }
    { Name = "Drive my Car"; RunningLength = 179; Genre = Drama; Director = { Name = "Ryusuke Hamaguchi"; Movies = 16 }; IMDBRating = 7.6 }
    { Name = "Dune"; RunningLength = 155; Genre = Fantasy; Director = { Name = "Denis Villeneuve"; Movies = 24 }; IMDBRating = 8.1 }
    { Name = "King Richard"; RunningLength = 144; Genre = Sport; Director = { Name = "Reinaldo Marcus Green"; Movies = 15 }; IMDBRating = 7.5 }
    { Name = "Licorice Pizza"; RunningLength = 133; Genre = Comedy; Director = { Name = "Paul Thomas Anderson"; Movies = 49 }; IMDBRating = 7.4 }
    { Name = "Nightmare Alley"; RunningLength = 150; Genre = Thriller; Director = { Name = "Guillermo Del Toro"; Movies = 22 }; IMDBRating = 7.1 }
]

// Identify probable Oscar winners movies
let oscarWinners = movies |> List.filter (fun movie -> movie.IMDBRating > 7.4)

printfn "Probable Oscar Winners: %A" oscarWinners
