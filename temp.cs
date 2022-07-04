 // ### `Movieilh` entity

// - Title: max 255 chars, required
// - ReleaseDate: max bir yildan keyin, min 60 yil avval, required
// - Id: Guid, Db required
// - Genre: enum, [Action, Horror, …], Enum qiymatlar son sifatida emas, string sifatida ko’rinishi kerak. Databasega esa int bolib saqlanishi kerak. Required
// - Description: max 1024 chars
// - Imdb: max 10.0 min 0.0, Required
// - Viewed: long min 0, max infinite
//     - har bir get request bo’ganida oshirib boriladi.
//     - get request /movies/{id} ga bo’lganidagina oshiladi. 

// ## Enpoints

// - `/movies` GET - gets all movies
// - `/movies/{id}` GET - berilgan ID dagi movie keladi
// - `/movies` POST - movie create qiladi
// - `/movies/{id}` DELETE - berilgan IDdagi movieni o’chiradi

// Entity va DTO lar to’g’ri ishlatilishi shart.