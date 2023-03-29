import * as React from "react";
import { ScrollView, View, Text, StyleSheet, TextInput, Pressable } from "react-native";
import { useEffect, useState } from "react";


export function PurchaseTicketsScreen() {
    return (
      <View>
        <Text style={{fontSize: 22, fontWeight: 'bold', alignSelf: 'center', textAlign: 'center', marginTop: 10 }}>
          Where are you traveling from?
        </Text>
        <TextInput
          style={styles.input}
          placeholder="Austin, TX"
          keyboardType="alphabetic"
        />

        <Text style={{fontSize: 22, fontWeight: 'bold', alignSelf: 'center', textAlign: 'center', marginTop: 10 }}>
          Where do you want to travel?
        </Text>
        <TextInput
          style={styles.input}
          placeholder="Houston, TX"
          keyboardType="alphabetic"
        />

        <Pressable
            //onPress={() => navigation.push('Ticket', {ticketName: ticket1} )}
            style={styles.button}
        >
          <Text style={styles.buttonText}>Go</Text>
        </Pressable>
      </View>
    );
  }

  const styles = StyleSheet.create({
    input: {
      height: 40,
      margin: 12,
      borderWidth: 1,
      padding: 7,
      fontSize: 20,
      marginBottom: 25
    },
    button :{
      alignSelf: 'center',
      alignItems: 'center',
      paddingVertical: 10,
      paddingHorizontal: 5,
      borderRadius: 0,
      width: 75,
      backgroundColor: '#1b225a',
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
  });