import { NavigationContainer } from '@react-navigation/native';
import { createNativeStackNavigator } from '@react-navigation/native-stack';
import { StatusBar } from 'expo-status-bar';
import { StyleSheet, Text, View } from 'react-native';
import { TicketsScreen } from './Screens/TicketsScreen';
import {HomeScreen} from './Screens/HomeScreen';
import { PurchaseTicketsScreen } from './Screens/PurchaseTickets';



const Stack = createNativeStackNavigator();

export default function App() {
  return (
    <NavigationContainer>
      <Stack.Navigator>
        <Stack.Screen 
          name="Home" 
          component={HomeScreen}
          options={styles.headers}
          />
        <Stack.Screen 
          name="Tickets" 
          component={TicketsScreen}
          options={styles.headers}
        />
        <Stack.Screen 
          name="Purchase Tickets" 
          component={PurchaseTicketsScreen}
          options={styles.headers}
          />
      </Stack.Navigator>
    </NavigationContainer>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#ffffff',
    alignItems: 'center',
    justifyContent: 'center',
  },
  headers:{
    headerStyle: {
      backgroundColor: '#0c8d21',
    },
    headerTintColor: '#ffffff',
    headerTitleStyle: {
      fontWeight: 'bold',
    },
  }
});
