import * as React from "react";
import { ImageBackground,Pressable,Button, ScrollView, View, Text, StyleSheet } from "react-native";
import { useEffect, useState } from "react";
import { NavigationContainer } from '@react-navigation/native';
import { createNativeStackNavigator } from '@react-navigation/native-stack';

const backgroundImage = require("../assets/BackgroundImage.jpg") ;

export function HomeScreen({ navigation }) {
    return (
      <View style={styles.background}>
        <ImageBackground source={backgroundImage} style={styles.image}>
          <Text style={styles.subheader}>Welcome to EnTrack</Text>
          <Pressable
              onPress={() => navigation.navigate('My Tickets')}
              style={styles.button}
          >
            <Text style={styles.buttonText}>My Tickets</Text>
          </Pressable>
          <Pressable
              onPress={() => navigation.navigate('Purchase Tickets')}
              style={styles.button}
          >
            <Text style={styles.buttonText}>Purchase Tickets</Text>
          </Pressable>
          <Pressable
              onPress={() => navigation.navigate('Login')}
              style={styles.button}
          >
            <Text style={styles.buttonText}>Login</Text>
          </Pressable>
        </ImageBackground>
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
      borderRadius: 2,
      borderColor: '#000000',
      borderWidth: 1,
      borderColor: '#ffffff',
      backgroundColor: '#f43f5e',
       

    },
    buttonText:{
      fontSize: 16,
      lineHeight: 21,
      fontWeight: 'bold',
      letterSpacing: 0.25,
      color: 'white',
    },
    
    subheader:{
      fontSize: 33,
      fontFamily:"Optima" ,
      fontWeight: 'bold',
      marginLeft:'auto',
      marginRight:'auto',
      marginBottom: 100,
      paddingLeft: 10,
      paddingRight: 10,
      paddingBottom: 10,
      paddingTop: 10,
      borderRadius: 5,
      borderWidth: 1,
      borderColor: '#ffffff',
      backgroundColor: '#1b225a',
      color: '#ffffff'
    },
    image: {
      height: '100%',
      justifyContent: 'center',
    }
    
  });
  