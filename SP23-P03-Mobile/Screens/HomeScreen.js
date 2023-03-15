import * as React from "react";
import { Pressable,Button, ScrollView, View, Text, StyleSheet } from "react-native";
import { useEffect, useState } from "react";
import { NavigationContainer } from '@react-navigation/native';
import { createNativeStackNavigator } from '@react-navigation/native-stack';

export function HomeScreen({ navigation }) {
    return (
      <View style={styles.background}>
        <Text style={styles.subheader}>Welcome to EnTrack</Text>
        <Pressable
            onPress={() => navigation.navigate('Tickets')}
            style={styles.button}
        >
          <Text style={styles.buttonText}>Tickets</Text>
        </Pressable>
        <Pressable
            onPress={() => navigation.navigate('Purchase Tickets')}
            style={styles.button}
        >
          <Text style={styles.buttonText}>Purchase Tickets</Text>
        </Pressable>
        
      </View>
    );
  }

  const styles = StyleSheet.create({
    background: {
      backgroundColor: "##ffffff",
    },
    button :{
      alignItems: 'center',
      alignSelf: 'center',
      justifyContent: 'center',
      marginBottom: 15,
      paddingVertical: 10,
      paddingHorizontal: 5,
      width: 170,
      borderRadius: 0,
      borderColor: "#000000",
      backgroundColor: '#56ade7',
       

    },
    buttonText:{
      fontSize: 16,
      lineHeight: 21,
      fontWeight: 'bold',
      letterSpacing: 0.25,
      color: 'black',
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
  