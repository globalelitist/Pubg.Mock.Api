# Pubg.Api
A C# PUBG API with fake data. Used for building apps against :)

### Live test
Latest master runs at: [https://pubg-api-globalelitist.herokuapp.com/](https://pubg-api-globalelitist.herokuapp.com/). Feel free to use it! :smile:

You can test for a non-existant match with the ID: `00000000-0000-0000-0000-000000000000`

## Examples

* Status

`/status`

* Last 5 matches

`/shards/pc-eu/matches/`

* Specific match (With response code: 200)

`/shards/pc-eu/matches/123/` 

`/shards/pc-eu/matches/3349ee41-bcdc-4dde-8fa0-1baedbabce7e` 

`/shards/pc-eu/matches/alphabet/` 

* Specific match (With response code: 404)

`/shards/pc-eu/matches/00000000-0000-0000-0000-000000000000`

## Contributing

Feel free to create issues, pull requests or just contact `leewalkergm` here or `IOException#7621` on discord
