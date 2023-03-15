import * as React from "react";
import { Image,Pressable, Button, ScrollView, View, Text, StyleSheet } from "react-native";
import { useEffect, useState } from "react";
import { BaseUrl } from "../configuration";

export function TicketScreen({navigation}) {

    const tickets= useState(() => {
      fetch(`${BaseUrl}/api/stations`)
      .then(x => x.text());
    }, []);

    return (
      <View>
        <Image
          source={require("../assets/SampleQRCode.jpg")}
          resizeMode= 'contain'
          style={{
            width: 250, 
            height: 250,
            alignSelf: 'center',
            marginTop: 100,
            
          }}
          />
          <Text style={{fontSize: 22, fontWeight: 'bold', alignSelf: 'center', textAlign: 'center'}}>
            Scan this instead of printing out a ticket.
          </Text>
        
      </View>
    );
}