import * as React from "react";
import { Pressable, Button, ScrollView, View, Text, StyleSheet, TextInput } from "react-native";
import { useEffect, useState } from "react";
import axios from 'axios';
import { BaseUrl } from "../configuration";
import { AccountScreen } from './AccountScreen';
import MaterialCommunityIcons from 'react-native-vector-icons/MaterialCommunityIcons';




export function LogInScreen({ navigation }) {
  const [username, setUsername] = useState('');
  const [password, setPassword] = useState('');

  return (
    <View style={styles.background}>
      <TextInput
        style={styles.input}
        placeholder="Username"
        keyboardType="default"
        value={username}
        onChangeText={(username) => setUsername(username)}
      />
      <TextInput
        style={styles.input}
        placeholder="Password"
        keyboardType="default"
        secureTextEntry={true}
        value={password}
        onChangeText={(password) => setPassword(password)}
      />
      <Pressable
        onPress={handleSubmit}
        style={styles.button}
      >
        <Text style={styles.buttonText}>Login</Text>
      </Pressable>
    </View>
  );

  function handleSubmit() {
    axios.post(`${BaseUrl}/api/authentication/login`, { username, password })
    .then((response) => {
        changeTab(response.data.userName);
    });
    
  }

  function changeTab(username){
    navigation.setOptions({
      title: username,
      tabBarIcon: ({ color, size }) => (
        <MaterialCommunityIcons name="account-circle" color={color} size={size} />
      ),
      screen: {AccountScreen}
    });
    navigation.navigate('Home');
  }
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
  button: {
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
    backgroundColor: '#1b225a',


  },
  buttonText: {
    fontSize: 16,
    lineHeight: 21,
    fontWeight: 'bold',
    letterSpacing: 0.25,
    color: 'white',
  },

  subheader: {
    fontSize: 30,
    fontWeight: 'bold',
    marginTop: 20,
    marginLeft: 'auto',
    marginRight: 'auto',
    marginBottom: 30,
    paddingLeft: 10,
    paddingRight: 10,
    paddingBottom: 10,
    paddingTop: 10,
    backgroundColor: '#1b225a'
  }
});
