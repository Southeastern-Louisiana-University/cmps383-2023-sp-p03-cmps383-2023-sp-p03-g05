import { NavigationContainer } from '@react-navigation/native';
import { createNativeStackNavigator } from '@react-navigation/native-stack';
import { StatusBar } from 'expo-status-bar';
import { StyleSheet, Text, View } from 'react-native';
import { AllTicketsScreen } from './Screens/AllTicketsScreen';
import {HomeScreen} from './Screens/HomeScreen';
import { LogInScreen } from './Screens/LogInScreen';
import { PurchaseTicketsScreen } from './Screens/PurchaseTicketsScreen';
import { TicketScreen } from './Screens/TicketScreen';



const Stack = createNativeStackNavigator();

export default function App() {
  return (
    <NavigationContainer>
      <Stack.Navigator >
        <Stack.Group screenOptions={styles.headers} >
          <Stack.Screen 
            name="Home" 
            component={HomeScreen}
            />
          <Stack.Screen 
            name="All Tickets" 
            component={AllTicketsScreen}
          />
          <Stack.Screen 
            name="Purchase Tickets" 
            component={PurchaseTicketsScreen}
            />
            <Stack.Screen 
              name="Ticket" 
              component={TicketScreen}
              options={({ route }) => ({ title: `${route.params.ticketName} Ticket` })}
            />
            <Stack.Screen 
              name="Login" 
              component={LogInScreen}
            />
          </Stack.Group>
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
