import * as React from "react";
import { Button, ScrollView, View, Text, StyleSheet } from "react-native";
import { useEffect, useState } from "react";
import { BaseUrl } from "../configuration";

export function TicketsScreen({navigation}) {

    const tickets= useState(() => {
      fetch(`${BaseUrl}/api/stations`)
      .then(x => x.text());
    }, []);

    return (
      <View style={{ flex: 1, alignItems: 'center', justifyContent: 'center' }}>
        <Text>Tickets Screen</Text>
        
      </View>
    );
}
