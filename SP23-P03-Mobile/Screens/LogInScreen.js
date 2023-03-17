import * as React from "react";
import { Pressable,Button, ScrollView, View, Text, StyleSheet, TextInput } from "react-native";
import { useEffect, useState } from "react";
import { NavigationContainer } from '@react-navigation/native';
import { createNativeStackNavigator } from '@react-navigation/native-stack';

export function LogInScreen({ navigation }) {
    return (
      <View style={styles.background}>
       <TextInput
          style={styles.input}
          placeholder="Username"
          keyboardType="alphabetic"
        />
        <TextInput
          style={styles.input}
          placeholder="Password"
          keyboardType="alphabetic"
          secureTextEntry={true}
        />
        <Pressable
            onPress={() => navigation.navigate('Home')}
            style={styles.button}
        >
          <Text style={styles.buttonText}>Login</Text>
        </Pressable>
        
      </View>
    );
  }

  const styles = StyleSheet.create({
    background: {
      backgroundColor: "##ffffff",
    },
    input: {
        height: 40,
        margin: 12,
        borderWidth: 1,
        padding: 7,
        fontSize: 20,
        marginBottom: 25
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
      borderColor: '#000000',
      borderWidth: 1,
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
  