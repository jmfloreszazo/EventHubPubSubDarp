﻿// See https://aka.ms/new-console-template for more information

using PubSubDarpSample.Publisher;

await GenerateGuestActionsMessages("pub-microservice", "mydaprdemoeventhub");

async Task GenerateGuestActionsMessages(string pubSubName, string topic)
{
    var guestPubService = new EventService();
    await guestPubService.SendEventMessages(2, pubSubName, topic);
    //var testSecretVar = "";
}
