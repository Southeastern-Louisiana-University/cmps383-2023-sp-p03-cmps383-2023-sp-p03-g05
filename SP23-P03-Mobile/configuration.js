export const BaseUrl = 
    process.env.NODE_ENV === "Production" ?
        "http://selu383-sp23-p03-g05.azurewebsites.net" :
        "https://ec01-147-174-75-6.ngrok.io"; //local ngrok url