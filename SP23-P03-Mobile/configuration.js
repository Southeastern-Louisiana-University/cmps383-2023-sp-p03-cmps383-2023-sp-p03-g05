export const BaseUrl = 
    process.env.NODE_ENV === 'production' ? //environment variables in expo for help
        "https://selu383-sp23-p03-g05.azurewebsites.net" :
        "https://f99a-147-174-75-100.ngrok.io"; //local ngrok url