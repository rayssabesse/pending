import 'react-native-gesture-handler';
import { GestureHandlerRootView } from "react-native-gesture-handler";
import React, { Component } from 'react';
import { NavigationContainer } from '@react-navigation/native';
import { createStackNavigator } from '@react-navigation/stack';
import { StatusBar, StyleSheet } from 'react-native';

import Login from './src/screens/login';
import SignUp from './src/screens/signUp';
import First from './src/screens/first';
import Settings from './src/screens/settings';
import Home from './src/screens/main';
import Clients from './src/screens/clients';
import statistics from './src/screens/statistics';


const AuthStack = createStackNavigator();

class App extends Component {
  render() {
    return (
      <NavigationContainer>
        <AuthStack.Navigator>
          <AuthStack.Screen
            name='First'
            options={{ headerShown: false }}
            component={First}
          />

          <AuthStack.Screen
            name='Login'
            options={{ headerShown: false }}
            component={Login}
          />

          <AuthStack.Screen
            name='Main'
            options={{ headerShown: false }}
            component={Home}
          />

          <AuthStack.Screen
            name='Settings'
            options={{ headerShown: false }}
            component={Settings}
          />

          <AuthStack.Screen
            name='SignUp'
            options={{ headerShown: false }}
            component={SignUp}
          />

          <AuthStack.Screen
            name='Clients'
            options={{ headerShown: false }}
            component={Clients}
          />

          <AuthStack.Screen
            name='statistics'
            options={{ headerShown: false }}
            component={statistics}
          />

        </AuthStack.Navigator>
      </NavigationContainer>
    );
  }
}

const styles = StyleSheet.create({
  main: {
    flex: 1,
    backgroundColor: '#F1F1F1',
  },

  tabBarIcon: {
    width: 22,
    height: 22,
  },
});

export default App;