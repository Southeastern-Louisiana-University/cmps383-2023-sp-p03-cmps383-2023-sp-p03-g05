import * as React from "react";
import { Pressable, Button, ScrollView, View, Text, StyleSheet } from "react-native";
import { useEffect, useState } from "react";
import { BaseUrl } from "../configuration";
import { createNativeStackNavigator } from '@react-navigation/native-stack';
import { TicketScreen } from './TicketScreen.js';


const Stack = createNativeStackNavigator();


export function AllTicketsScreen({navigation}) {

    const tickets= useState(() => {
      fetch(`${BaseUrl}/api/stations`)
      .then(x => x.text());
    }, []);

    const ticket1= "New Orleans to Jackson";
    const ticket2= "Baton Rouge to Houston";

    return (
          <View>
            <Pressable
                onPress={() => navigation.push('Ticket', {ticketName: ticket1} )}
                style={styles.button1}
            >
              <Text style={styles.buttonText}>{ticket1}</Text>
            </Pressable>
            <Pressable
                onPress={() => navigation.navigate('Ticket', {ticketName: ticket2})}
                style={styles.button2}
            >
              <Text style={styles.buttonText}>{ticket2}</Text>
            </Pressable>
            
          </View>
    );
}

const styles = StyleSheet.create({
  background: {
    backgroundColor: "##ffffff",
  },
  button1 :{
    alignItems: 'center',
    justifyContent: 'center',
    paddingVertical: 10,
    paddingHorizontal: 5,
    borderRadius: 0,
    backgroundColor: '#1b225a',
    borderColor: '#000000',
    borderWidth: 1

  },
  button2 :{
    alignItems: 'center',
    justifyContent: 'center',
    paddingVertical: 10,
    paddingHorizontal: 5,
    borderRadius: 0,
    backgroundColor: '#434c8c',
    borderColor: '#000000',
    borderWidth: 1
  },
  buttonText:{
    fontSize: 16,
    lineHeight: 21,
    fontWeight: 'bold',
    letterSpacing: 0.25,
    color: 'white',
  },
  
  subheader:{
    fontSize: 30,
    fontWeight: 'bold',
    marginTop: 20,
    marginLeft:'auto',
    marginRight:'auto',
    marginBottom: 30,
    paddingLeft: 10,
    paddingRight: 10,
    paddingBottom: 10,
    paddingTop: 10,
    backgroundColor: '#56ade7'
  }
});
