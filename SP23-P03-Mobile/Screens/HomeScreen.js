import * as React from "react";
import { Button, ScrollView, View, Text, StyleSheet } from "react-native";
import { useEffect, useState } from "react";
import { NavigationContainer } from '@react-navigation/native';
import { createNativeStackNavigator } from '@react-navigation/native-stack';

export function HomeScreen({ navigation }) {
    return (
      <View style={{ flex: 1, alignItems: 'center', justifyContent: 'center' }}>
        <Text>Welcome to EnTrack</Text>
        <Button
            title="View your Tickets"
            onPress={() => navigation.navigate('Tickets')}
        />
        <Button
            title="Purchase Tickets"
            onPress={() => navigation.navigate('Purchase Tickets')}
        />
      </View>
    );
  }