import { NavigationContainer } from '@react-navigation/native';
import { createNativeStackNavigator } from '@react-navigation/native-stack';
import { StatusBar } from 'expo-status-bar';
import { StyleSheet, Text, View } from 'react-native';
import { AllTicketsScreen } from './Screens/AllTicketsScreen';
import {HomeScreen} from './Screens/HomeScreen';
import { LogInScreen } from './Screens/LogInScreen';
import { PurchaseTicketsScreen } from './Screens/PurchaseTicketsScreen';
import { TicketScreen } from './Screens/TicketScreen';
import { createBottomTabNavigator } from '@react-navigation/bottom-tabs';
import MaterialCommunityIcons from 'react-native-vector-icons/MaterialCommunityIcons';


const Stack = createNativeStackNavigator();
const Tab = createBottomTabNavigator();

function TabNavigator(){
  return (
      <Tab.Navigator screenOptions={styles.headers} >
        <Tab.Screen name="Home" component={HomeScreen} 
          options={{
            tabBarIcon: ({ color, size }) => (
              <MaterialCommunityIcons name="home" color={color} size={size} />
            ),
          }}
        />
        <Tab.Screen name="My Tickets" component={AllTicketsScreen} 
          options={{
            tabBarIcon: ({ color, size }) => (
              <MaterialCommunityIcons name="qrcode" color={color} size={size} />
            ),
          }}
        />
        <Tab.Screen name="Purchase Tickets" component={PurchaseTicketsScreen} 
        options={{
          tabBarIcon: ({ color, size }) => (
            <MaterialCommunityIcons name="train" color={color} size={size} />
          ),
        }}
        />
        <Tab.Screen name="Login" component={LogInScreen} 
        options={{
          tabBarIcon: ({ color, size }) => (
            <MaterialCommunityIcons name="login" color={color} size={size} />
          ),
        }}
        
        />
      </Tab.Navigator>
  );
}

export default function App() {
  return (
    <NavigationContainer>
      <Stack.Navigator >
        <Stack.Group screenOptions={styles.headers} >
          <Stack.Screen name='home' component={TabNavigator} options={{headerShown: false}}/>
          
            <Stack.Screen 
              name="Ticket" 
              component={TicketScreen}
              options={({ route }) => ({ title: `${route.params.ticketName} Ticket` })}
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
      backgroundColor: '#f43f5e',
    },
    headerTintColor: '#ffffff',
    headerTitleStyle: {
      fontWeight: 'bold',
    },
    tabBarActiveTintColor:'#f43f5e',
    tabBarActiveBackgroundColor: '#1b225a',
    tabBarInactiveBackgroundColor: '#1b225a',
    backBehavior: "order",
    
  },

});
