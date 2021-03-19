public class MYCLASSNAME : MonoBehaviour {
FIXME_VAR_TYPE api_url= "https://api.rawg.io/api/";
FIXME_VAR_TYPE api_key= 'e7aeda6159b24ff6bd055e6b1c9fa6d1';
getPlatforms(5, 0);

void  getPlatforms (platformId, depth){
    FIXME_VAR_TYPE res= request('GET', api_url+ 'platforms/' + platformId + '?key='+ api_key );
    FIXME_VAR_TYPE json= JSON.parse(res.getBody('utf8'));

    console.log(json);

    // FIXME_VAR_TYPE platforms= json["cast"];
} 

void  getGamesPlatform (gameId, depth){
    FIXME_VAR_TYPE res= request('GET', api_url+'games/'+ gameId + '?key='+api_key );
    FIXME_VAR_TYPE json= JSON.parse(res.getBody('utf8'));
    console.log(json);
}
}
