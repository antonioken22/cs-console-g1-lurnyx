﻿/**
 * @author Antonio, Kenette John
 * @createdAt June 9, 2025
 */

using Group1Lurnyx.Animation;
using Group1Lurnyx.Interfaces;

namespace Group1Lurnyx.Entities.BaseEntities
{
    public abstract class Animal : ICanMove, ICanEat, ICanDrink
    {
        public double Velocity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Thirst { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Hunger { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Run(int id, string name)
        {
            if (id == 0)
            {
                string[] frames = { $"{name} is running.  ", $"{name} is running.. ", $"{name} is running...", $"{name} is running   " };
                TextAnimation.TextAnimation1(frames, 100, name, "running");
            }
            else
            {
                name ??= "Tom";
                string[] frames = { @"
                            ▄▄█▄▄▄,          ▄▄▓▓█▓▓█▓▄╖                                        
                            ██████████▄▄▄▄▄▄███████████████,                   ,▄█`             
                            ███▀▀████████████████████████████▄▄,,,,,,,,,,▄▄▄▄██▀`               
                                ╙███████████████████████████▌`▀▀▀▀▀▀▀▀▀▀`                       
                                    ▀████████████████████████▀                                  
                                        ▀▀▀▀▀██████▄██████▀`                                    
                                        ▀███████▀██████                                         
                                                    ███                                         
                                                    ▄██▀                                        
                                                ▄▄██▀'                                          
                                                ▀▀                                              
                                                                                                ", @"
                               ,▄                                                               
                            ▄███████▄▄      ,▄▄▄▄████▓▓@▄▄                                      
                            ████████████████████████████████,                  ,▄               
                             ▀   ███████████████████████████████▄▄▄,,      ,▄▄█▀'               
                                  ▀██████████████████████████C    ""▀▀▀▀▀▀▀▀▀`                  
                                    ▀█████████▀▀▀▀██████████▌                                   
                                      ▀██, ██Q▄██ ▐███▀██████                                   
                                         ` ▀██▀▀  ▐██▌  ▀█████▄▄                                
                                                  ▐██▌     ▀▀▀██▌                               
                                                ,████        ██▀                                
                                             ▀██▀▀'        ██▀                                  
                                                                                                ", @"
                              ▄▄█▄▄▄,,                                                          
                            █████████████▄▄▄▄▄▄▄▄▄▄▄▄▄█████████▄                                
                            ███▀▀█████████████████████████████████▄▄                            
                                  ▀████████████████████████████████▄▀▀█▄▄▄▄,     ,,▄▄           
                                   ▐██████████████████▀▀▀""▀█████████▄▄▄▄▄ ▀▀▀▀▀▀▀▀▀▀           
                               ,▄██████████████▀▀▀▀`       ▐███████████████▄,                   
                              ▐██▀██▄                       ▀█████████,    ▀████                
                              ██   ▀▀`                        `▀▀▀▀▀████▄                       
                                                                       ▀██                      
                                                                        ██▌                     
                                                                        `▀""                    
                                                                                                ", @"
                                    ,▄                                                          
                                  ▄████████▄▄▄             ,▄╥▄æ▄▄▄▄▄▄,                         
                                  ████████████████▄▄▄▄▄█████████████████▀▀██▄▄,                 
                                   ▀   ▀██████████████████████████████████▄█▄▄███▄▄,            
                                       ╓████████████████████████████████████████████████▀       
                            ,,  ,,,▄▄▄████████████████████████▀     ▀███████▀▀    '""`'         
                            ▀██████████████▀  ▀▀▀▀████████▀▀                                    
                               - --`                                                            
                                                                    
                                                                    
                                                                    
                                                                                                ", @"
                                                                ,▄▄▄▄▄▄,    ,,,,,,              
                                  ╓▄▄▄,                    ,▄████████████▀▀▀▀▀▀▀▀▀▀▀██▄▄        
                                ▐██████████▄▄,       ,▄▄████████████████▌,▄            ▀▀█▄     
                                ▐███████████████████████████████████████████▄            ╙█L    
                                      ╙███████████████████████████████████████                  
                                      ,▄█████████████████████▀███████████▀█████▄                
                            ▄▄,,▄▄▄▄▄████████████████████▀▀    ▀▀██▀▀▀     ▀▀█▀▀                
                            ▀▀▀▀▀▀▀▀▀▀▀▀█████▀▀▀▀▀▀▀▀▀-                                         
                                       /█████                                                   
                                     ,▄███▀                                                     
                                 ,▄▄██▀""                                                       
                                 ▀▀▀                                                            
                                                                                                ", @"
                                                           ▄▄▄████▄▄  ,▄▄███▀▀▀▀▀▀▀▀██▄▄        
                                                      ▄▄██████████████▀▀               ▀██▄     
                             ╓▄██▄▄▄▄,            ▄▄███████████████████                  `▀     
                            ▐█████████████████████████████████████████""                        
                            ▀███████████████████████████████████████████▌                       
                                    ███████████████████████▀▀▀▀█████████                        
                                    j████████████████████▀         ╒███▌                        
                                     ████████████████▀▀            ▐███                         
                                    ╒█████▀▀▀▀▀▀▀▀███▄▄            ╙█▀                          
                                   ,█████▀          ▀████▄                                      
                                 ▄███▀▀                ▀███▄                                    
                             ▄▄███▀                       ▀▀                                    
                             ▀▀`                                                                
                                                                                                ", @"
                                                      ,▄▄▄▄▄,             ,▄▄▄███▀▀▀▀▀███╕      
                                                ,▄▄█████████████▄     ,▄██▀▀-                   
                            ,▄██████▄▄▄▄,,,▄▄██████████████████████▄██▀'                        
                            ████████████████████████████████████████                            
                            ▀█▀▀▀▀▀████████████████████████████████`                            
                                    `▀██████████████████▀█████████                              
                                       ▀▀█████████████▄   ▄██████▀                              
                                          `▀▀███▀▀'""▀███████████                               
                                             ▐██▄      ▀███████▀                                
                                              ╙██▌         ""▀▀▀                                
                                               ╙██                                              
                                                ▐█▌                                             
                                                                                                ", @"
                                                                              ,▄▄▄▄▄▄▄          
                                               ▄▄██████▄▄,                ,▄██▀▀                
                                            ▄███████████████▄           ▄██▀                    
                             ▄█████▄▄▄, ,,▄████████████████████▄     ▄██▀                       
                            █████████████████████████████████████▄██▀▀                          
                            ▀██▀▀▀██████████████████████████████▀                               
                                    ▀████████████████▌-▀█████▀▀▀                                
                                       ▀▀████████████████████▌                                  
                                           ▀▀▀█████▀███▄▄                                       
                                             ▄▄█████▄, ▀▀                                       
                                             ▀▀`   ▀█████µ                                      " };
                TextAnimation.TextAnimation2(frames, 100, name, "running");
            }
        }
        public abstract void Back();

        public abstract double GetVelocity(double distance, double time);


        public void Drink()
        {
            throw new NotImplementedException();
        }

        public void Eat()
        {
            throw new NotImplementedException();
        }

    }
}
