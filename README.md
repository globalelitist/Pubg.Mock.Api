# Pubg.Api
A C# PUBG API with fake data. Used for building apps against :)

---

Latest runs at: [https://pubg-api-globalelitist.herokuapp.com/](https://pubg-api-globalelitist.herokuapp.com/)

You can test for a non-existant match with the ID: `00000000-0000-0000-0000-000000000000`

---

## Examples

* Status

`https://pubg-api-globalelitist.herokuapp.com/status`

* Last 5 matches

`https://pubg-api-globalelitist.herokuapp.com/shards/pc-eu/matches/`

* Specific match (With response code: 200)

- `https://pubg-api-globalelitist.herokuapp.com/shards/pc-eu/matches/123/` 
- `https://pubg-api-globalelitist.herokuapp.com/shards/pc-eu/matches/3349ee41-bcdc-4dde-8fa0-1baedbabce7e` 
- `https://pubg-api-globalelitist.herokuapp.com/shards/pc-eu/matches/alphabet/` 

* Specific match (With response code: 404)

`https://pubg-api-globalelitist.herokuapp.com/shards/pc-eu/matches/00000000-0000-0000-0000-000000000000`


## Contributing

Feel free to create issues, pull requests or just contact `leewalkergm` here or `IOException#7621` on discord
