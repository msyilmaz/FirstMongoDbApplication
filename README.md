# FirstMongoDbApplication
Learn Mongo Db


#Request Urls
Get RockSongs : https://localhost:44309/api/v1/RockSongs

Get RockSong : https://localhost:44309/api/v1/RockSongs/{id}

Add RockSong : https://localhost:44309/api/v1/RockSongs
 => Body : { "name":"bohamian rhapsody", "singer":"Queen" }

Update RockSong : https://localhost:44309/api/v1/RockSongs
 => Body : { "id" : "5e026bf2384adb66e4cee39c", "name" : "updated name", "singer" : "updated singer" }
 
Delete RockSong : https://localhost:44309/api/v1/RockSongs/{id}



#Kaynak 
Aşağıdaki kaynaklar baz alınarak hazırlanmıştır.

https://docs.microsoft.com/tr-tr/aspnet/core/tutorials/first-mongo-app

https://medium.com/@ertugrul.gamgam/asp-net-core-ile-mongodb-%C3%BCzerinde-repository-pattern-kullanarak-crud-i%CC%87%C5%9Flemlerinin-yap%C4%B1lmas%C4%B1-c5d301ea8d3e
