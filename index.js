const fs = require('fs');
var request = require('sync-request');
var json2csv = require('json2csv');

var api_url = "https://api.rawg.io/api/";
var api_key = 'e7aeda6159b24ff6bd055e6b1c9fa6d1';
getPlatforms(5, 0);

function getPlatforms(platformId, depth) {
    var res = request('GET', api_url+ 'platforms/' + platformId + '?key='+ api_key );
    var json = JSON.parse(res.getBody('utf8'));

    console.log(json);

    // var platforms = json["cast"];
} 

function getGamesPlatform(gameId, depth) {
    var res = request('GET', api_url+'games/'+ gameId + '?key='+api_key );
    var json = JSON.parse(res.getBody('utf8'));
    console.log(json);
}